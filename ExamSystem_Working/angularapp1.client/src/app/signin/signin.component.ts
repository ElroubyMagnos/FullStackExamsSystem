import { Component } from '@angular/core';
import { ManagerService } from '../manager.service';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';

@Component({
  selector: 'app-signin',
  templateUrl: './signin.component.html',
  styleUrl: './signin.component.css'
})
export class SigninComponent {

  constructor(private backend: ManagerService, private http: HttpClient, private router: Router)
  {
    if (localStorage.getItem('Name') != null)
    {
      router.navigateByUrl('/');
    }

    this.http.get<boolean>(`${this.backend.backendurl}/Base/CheckSignedIn/${localStorage.getItem('Name')}/${localStorage.getItem('Password')}`)
      .subscribe(x => {
        if (x) {
          router.navigateByUrl('/');
        }
      });
  }

  SignInDo(event: SubmitEvent, fullname: HTMLInputElement, tbc: HTMLInputElement)
  {
    event.preventDefault();

    if (fullname.value.length == 0 || tbc.value.length == 0) {
      alert('لا تترك حقل فارغ');
      return;
    }
    
    this.http.post<boolean>(`${this.backend.backendurl}/Base/CheckCredentials/`, 
      {
        Name: fullname.value,
        Password: tbc.value
      })
      .subscribe(x => {
        if (x) {
          localStorage.setItem('Name', fullname.value);
          localStorage.setItem('Password', tbc.value);

          window.location.replace('/');
        }
        else alert('بيانات التسجيل خاطئة');
      });
  }
}
