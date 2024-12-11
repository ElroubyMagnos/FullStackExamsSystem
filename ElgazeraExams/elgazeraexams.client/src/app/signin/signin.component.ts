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

    http.post<Boolean>(`${backend.backendurl}/Base/CheckSignedIn/`,
    {
      name: localStorage.getItem('Name'),
      uniqueNumber: localStorage.getItem('Password')
    })
    .subscribe(x => {
      if (x)
      {
        router.navigateByUrl('/');
      }
    });
  }

  SignInDo(event: SubmitEvent, fullname: HTMLInputElement, tbc: HTMLInputElement)
  {
    event.preventDefault();

    localStorage.setItem('Name', fullname.value);
    localStorage.setItem('Password', tbc.value);

    window.location.replace('/');
  }

  TextBoxChanged(el: HTMLInputElement)
  {
    if (el.value.length == 0)
        return;

    if (/^\d+$/.test(el.value.toString()) == false || el.value.toString().length != 6)
    {
      el.value = '';
      alert('يرجي ادخال الرقم الصحيح');
    }
  }
}
