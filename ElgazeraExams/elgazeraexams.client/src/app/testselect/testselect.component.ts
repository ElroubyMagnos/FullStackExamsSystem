import { ManagerService } from './../manager.service';
import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ExamMain } from '../exam-main';

@Component({
  selector: 'app-testselect',
  templateUrl: './testselect.component.html',
  styleUrl: './testselect.component.css'
})
export class TestselectComponent {

  Exams: ExamMain[] = [];

  spec: number = 0;
  goy: number = 0;

  GotoExam(id: number)
  {
    this.router.navigateByUrl(`/ce/${this.spec}/${this.goy}/${id}`);
  }

  constructor(private active: ActivatedRoute, private http: HttpClient, private backend: ManagerService,
    private router: Router)
  {
    this.spec = +active.snapshot.paramMap.get('spec');
    this.goy = +active.snapshot.paramMap.get('grade');

    if (this.spec == 0 || this.goy == 0 || this.spec == undefined || this.goy == undefined)
    {
      router.navigateByUrl('/');
    }

    this.http.get<ExamMain[]>(`${backend.backendurl}/Base/GetExamCover/${this.spec}/${this.goy}`)
    .subscribe(x => this.Exams = x);
  }
}
