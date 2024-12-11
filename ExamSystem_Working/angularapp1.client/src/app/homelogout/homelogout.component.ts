import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ManagerService } from '../manager.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-homelogout',
  templateUrl: './homelogout.component.html',
  styleUrl: './homelogout.component.css'
})
export class HomelogoutComponent implements OnInit
{

  ngOnInit()
  {
    if (localStorage.getItem('Name') != null)
    {
      this.router.navigateByUrl('/homelogin');
    }
    this.http.get<boolean>(`${this.backend.backendurl}/Base/CheckSignedIn/${localStorage.getItem('Name')}/${localStorage.getItem('Password')}`)
      .subscribe(x => {
        if (x) {
          this.router.navigateByUrl('/homelogin');
        }
      });
  }

  constructor(private http: HttpClient, private backend: ManagerService, private router: Router)
  {

  }
}
