import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { ActivatedRoute, Route, Router } from '@angular/router';
import { ManagerService } from '../manager.service';
import { Gradeofyear } from '../gradeofyear';

@Component({
  selector: 'app-gradepage',
  templateUrl: './gradepage.component.html',
  styleUrl: './gradepage.component.css'
})
export class GradepageComponent {
  GradeYears: Gradeofyear[] = [];
  ID: number = 0;
  constructor(private active: ActivatedRoute, private http: HttpClient, private backend: ManagerService,
     private router: Router)
  {
    this.ID = +active.snapshot.paramMap.get('id');

    if (this.ID <= 0)
    {
      router.navigateByUrl('/');
    }

    this.http.get<Gradeofyear[]>(`${backend.backendurl}/Base/GetGrades/${this.ID}`)
    .subscribe(x =>
      {
        this.GradeYears = x
      });
  }
}
