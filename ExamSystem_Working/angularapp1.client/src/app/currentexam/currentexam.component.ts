import { Answer } from './../answer';
import { RightWrongQues } from './../right-wrong-ques';
import { Component } from '@angular/core';
import { ExamMain } from '../exam-main';
import { ChooseQues } from '../choose-ques';
import { ActivatedRoute, Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { ManagerService } from '../manager.service';
import { Observable } from 'rxjs';
import { EssayQues } from '../essay-ques';
import { EssayAnswers } from '../essay-answers';

@Component({
  selector: 'app-currentexam',
  templateUrl: './currentexam.component.html',
  styleUrl: './currentexam.component.css'
})
export class CurrentexamComponent {

  buffering: boolean = false;
  Open: boolean = true;
  Answers: Answer[] = [];
  EssayAnswers: EssayAnswers[] = [];
  TotalScore: number = 0;
  TimeOf: string;

  EssayChanged(id: number, Answer: string)
  {
    for (let i = 0; i < this.EssayAnswers.length; i++) 
    {
        if (this.EssayAnswers[i].quesid == id)
        {
          this.EssayAnswers[i].answer = Answer;
          return;
        }
    }

    this.EssayAnswers.push({
      answer: Answer,
      ismarked: false,
      quesid: id,
      studentname: localStorage.getItem('Name')
    });
  }

  SendAnswers()
  {
    if (this.Answers.length + this.EssayAnswers.length < this.TotalScore)
    {
      alert('لقد نسيت سؤالاً');
      return;
    }

    this.buffering = true;

    var obs = new Observable()
    {
      this.http.post(`${this.backend.backendurl}/Base/GetAnswersAfterExam/${this.examid}/${localStorage.getItem('Name')}/`, this.Answers)
      .subscribe();

      this.http.post(`${this.backend.backendurl}/Base/GetEssayAfterExam/`, this.EssayAnswers)
      .subscribe();

      alert('تم ارسال الاجابات، يرجي الانتظار حتي تظهر النتيجة')
      this.router.navigateByUrl('/');
    };

    obs.subscribe();
  }

  ColoritRightWrong(selected: HTMLButtonElement, other: HTMLButtonElement, id: number)
  {
    if (!this.Open)
        return;
    selected.style.backgroundColor = 'yellow';
    other.style.backgroundColor = 'white';

    var Target = {
      ischoose: false,
      quesid: id,
      selectedanswer: selected.value,
      student: +localStorage.getItem('Password')
    };

    for (var i = 0; i < this.Answers.length; i++)
    {
      if (this.Answers[i] != null && this.Answers[i].quesid == id  && this.Answers[i].ischoose == false)
      {
        var deletetarget = this.Answers.indexOf(this.Answers[i], 0);
        this.Answers.splice(deletetarget, 1);
      }
    }

    this.Answers.push(Target);
  }

  ColoritChoose(
    id: number,
    selected: HTMLButtonElement)
  {
    if (!this.Open)
    return;
    selected.style.backgroundColor = 'yellow';

    var Target = {
      ischoose: true,
      quesid: id,
      selectedanswer: selected.value,
      student: +localStorage.getItem('Password')
    };

    for (var i = 0; i < this.Answers.length; i++)
    {
      if (this.Answers[i] != null && this.Answers[i].quesid == id  && this.Answers[i].ischoose == true)
      {
        var deletetarget = this.Answers.indexOf(this.Answers[i], 0);
        this.Answers.splice(deletetarget, 1);
      }
    }

    this.Answers.push(Target);
  }

  spec: number = 0;
  goy: number = 0;
  examid: number = 0;

  exammain: ExamMain;
  choosequestions: ChooseQues[] = [];
  rightwrongquestions: RightWrongQues[] = [];
  essayquestions: EssayQues[] = [];

  constructor(private active: ActivatedRoute, private http: HttpClient, private backend: ManagerService,
    private router: Router)
  {
    this.spec = +active.snapshot.paramMap.get('spec');
    this.goy = +active.snapshot.paramMap.get('grade');
    this.examid = +active.snapshot.paramMap.get('examid');

    if (this.spec == 0 || this.goy == 0 || this.spec == undefined || this.goy == undefined
      || this.examid == 0 || this.examid == undefined)
    {
      router.navigateByUrl('/');
    }

    if (localStorage.getItem('Name') == null)
    {
      router.navigateByUrl('/');
    }

    this.http.get<boolean>(`${backend.backendurl}/Base/ExamSafety/${this.spec}/${this.goy}/${localStorage.getItem('Password')}`)
    .subscribe(x =>
    {
      if (!x)
      {
        alert('انت لست في هذه المرحلة الدراسية');

        router.navigateByUrl('/');
      }
    });

    this.http.get<boolean>(`${backend.backendurl}/Base/CheckExamCorrected/${this.examid}/${localStorage.getItem('Name')}`)
    .subscribe(x => 
    {
      if (x)
      {
        router.navigate([`result/${this.spec}/${this.goy}/${this.examid}`]);
      }
    });

    this.http.get<ExamMain>(`${backend.backendurl}/Base/GetExamByID/${this.spec}/${this.goy}/${this.examid}/${localStorage.getItem('Name')}`).subscribe(exam =>
    {
      this.http.get<boolean>(`${backend.backendurl}/Base/CheckExamTime/${exam.id}`)
      .subscribe(x =>
      {
        if (!x)
        {
          alert('هذا الامتحان مغلق');
          router.navigateByUrl('/');
        }
        else
        {
          setInterval(() => {
            this.http.get(`${backend.backendurl}/Base/TimeLeftForExam/${exam.id}`, {responseType: 'text'})
            .subscribe(s => 
              {
                this.TimeOf = s;
              });
          }, 1000);
        }
      });
      if (exam == null || exam == undefined)
      {
        alert('هذا الامتحان غير متاح الان');

        router.navigateByUrl('/');
      }
      else
      {
        this.exammain = exam;
        
        var obs = new Observable<void>()
        {
          this.http.get<ChooseQues[]>(`${backend.backendurl}/Base/GetChooseQuestionsByExamID/${exam.id}`)
          .subscribe(choose =>
          {
            this.choosequestions = choose;
            this.TotalScore += this.choosequestions.length;
          });

          this.http.get<RightWrongQues[]>(`${backend.backendurl}/Base/GetRightWrongQuestionsByExamID/${exam.id}`)
          .subscribe(rightwrong =>
          {
            this.rightwrongquestions = rightwrong;
            this.TotalScore += this.rightwrongquestions.length;
          });

          this.http.get<EssayQues[]>(`${backend.backendurl}/Base/GetEssayQuestionsByExamID/${exam.id}`)
          .subscribe(eq =>
          {
            this.essayquestions = eq;
            this.TotalScore += this.essayquestions.length;
          });

        };
        obs.subscribe();
      }
    });
  }
}
