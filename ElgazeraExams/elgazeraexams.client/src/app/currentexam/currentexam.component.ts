import { Answer } from './../answer';
import { RightWrongQues } from './../right-wrong-ques';
import { Component } from '@angular/core';
import { ExamMain } from '../exam-main';
import { ChooseQues } from '../choose-ques';
import { ActivatedRoute, Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { ManagerService } from '../manager.service';

@Component({
  selector: 'app-currentexam',
  templateUrl: './currentexam.component.html',
  styleUrl: './currentexam.component.css'
})
export class CurrentexamComponent {

  buffering: boolean = false;
  Open: boolean = true;
  Answers: Answer[] = [];
  TotalScore: number = 0;

  SendAnswers()
  {
    if (this.Answers.length < this.TotalScore)
    {
      alert('لقد نسيت سؤالاً');
      return;
    }

    this.buffering = true;

    this.http.post<number>(`${this.backend.backendurl}/Base/GetAnswersAfterExam/`, this.Answers)
    .subscribe(x =>
    {
      alert(`لقد احرزت ${x}/${this.TotalScore}`)
      this.router.navigateByUrl('/');
    });
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
    })


    this.http.get<ExamMain>(`${backend.backendurl}/Base/GetExamByID/${this.spec}/${this.goy}/${this.examid}/${+localStorage.getItem('Password')}`).subscribe(exam =>
    {
      this.http.get<boolean>(`${backend.backendurl}/Base/CheckExamTime/${exam.id}`)
      .subscribe(x =>
      {
        if (!x)
        {
          alert('هذا الامتحان مغلق');
          router.navigateByUrl('/');
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
        this.http.get<ChooseQues[]>(`${backend.backendurl}/Base/GetChooseQuestionsByExamID/${exam.id}`)
        .subscribe(choose =>
        {
          this.choosequestions = choose;
          this.TotalScore += this.choosequestions.length;

          this.http.get<RightWrongQues[]>(`${backend.backendurl}/Base/GetRightWrongQuestionsByExamID/${exam.id}`)
          .subscribe(rightwrong =>
          {
            this.rightwrongquestions = rightwrong;
            this.TotalScore += this.rightwrongquestions.length;
          });
        });
      }
    });
  }
}
