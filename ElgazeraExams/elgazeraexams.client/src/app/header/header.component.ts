import { Component, OnInit } from '@angular/core';
import { ManagerService } from '../manager.service';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrl: './header.component.css'
})
export class HeaderComponent implements OnInit {
  SignedIn: boolean = false;

  SignOut()
  {
    localStorage.clear();

    window.location.reload();
  }

  ngOnInit()
  {
    this.SignedIn = localStorage.getItem('Name') != null;

    this.http.post<boolean>(`${this.backend.backendurl}/Base/CheckSignedIn/`,
    {
      name: localStorage.getItem('Name'),
      uniqueNumber: localStorage.getItem('Password')
    })
    .subscribe(x => {
      this.SignedIn = !x;
    });
  }

  constructor(private backend: ManagerService, private http: HttpClient)
  {

  }
}
