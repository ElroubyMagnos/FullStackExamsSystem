import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ManagerService } from '../manager.service';
import { Observable } from 'rxjs';
import { ExamProgress } from '../exam-progress';
import { ExamMain } from '../exam-main';

@Component({
  selector: 'app-resultofexam',
  templateUrl: './resultofexam.component.html',
  styleUrl: './resultofexam.component.css'
})
export class ResultofexamComponent {
  spec: number = 0;
  goy: number = 0;
  examid: number = 0;

  Prog: ExamProgress;
  NameOfStudent: string;
  NameOfExam: string;

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

    var ob = new Observable()
    {
      this.http.get<boolean>(`${backend.backendurl}/Base/ExamSafety/${this.spec}/${this.goy}/${localStorage.getItem('Password')}`)
      .subscribe(x =>
      {
        if (!x)
        {
          alert('انت لست في هذه المرحلة الدراسية');
  
          router.navigateByUrl('/');
        }
      });

      this.http.get<ExamProgress>(`${backend.backendurl}/Base/GetResultForStudent/${this.examid}/${localStorage.getItem('Name')}`)
      .subscribe(x => 
        {
          this.Prog = x;
        });

      this.http.get(`${backend.backendurl}/Base/GetStudentByUnique/${localStorage.getItem('Password')}/`, {responseType: 'text'})
      .subscribe(x => 
      {
          this.NameOfStudent = x;
      });

      this.http.get(`${backend.backendurl}/Base/GetNameOfExamByID/${this.examid}/`, {responseType: 'text'})
      .subscribe(x => {
        this.NameOfExam = x;
      });

    };

    ob.subscribe();    
  }
}
