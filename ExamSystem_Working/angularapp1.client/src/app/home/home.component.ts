import { Component, OnInit } from '@angular/core';
import { ManagerService } from '../manager.service';
import { HttpClient } from '@angular/common/http';
import { TypeOfLearn } from '../type-of-learn';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent implements OnInit {

  TOL: TypeOfLearn[] = [];

  ngOnInit()
  {
    if (localStorage.getItem('Name') == null)
    {
      this.router.navigateByUrl('/');
    }
    this.http.get<boolean>(`${this.backend.backendurl}/Base/CheckSignedIn/${localStorage.getItem('Name')}/${localStorage.getItem('Password')}`)
      .subscribe(x => {
        if (!x) {
          this.router.navigateByUrl('/');
        }
      });
  }

  constructor(ms: ManagerService, private http: HttpClient, private backend: ManagerService, private router: Router)
  {
    http.get<TypeOfLearn[]>(ms.backendurl + '/Base/GetSpecality/')
    .subscribe(x => this.TOL = x);

  }
}
