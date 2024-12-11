import { Component } from '@angular/core';
import { ManagerService } from '../manager.service';
import { HttpClient } from '@angular/common/http';
import { Student } from '../student'
import { TypeOfLearn } from '../type-of-learn';
import { Gradeofyear } from '../gradeofyear';
import { Router } from '@angular/router';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrl: './signup.component.css'
})
export class SignupComponent {

  SpecialityChanged(specality: HTMLSelectElement)
  {
    this.GradeGroup = [];

    this.http.get<Gradeofyear[]>(`${this.backend.backendurl}/Base/GetYearOfGrade/${specality.value}`)
    .subscribe(x => this.GradeGroup = x);
  }

  GradeGroup: Gradeofyear[] = [];

  SpecialityGroup: TypeOfLearn[] = [];

  constructor(private backend: ManagerService, private http: HttpClient, private router: Router)
  {
    if (localStorage.getItem('Name') != null)
    {
      router.navigateByUrl('/');
    }

    http.get<TypeOfLearn[]>(`${backend.backendurl}/Base/GetSpecality/`)
    .subscribe(x => this.SpecialityGroup.push(...x));

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

  SubmitAccount(event: SubmitEvent,
    namefour: HTMLInputElement,
    tbc: HTMLInputElement,
    grouptype: HTMLInputElement,
    year: HTMLSelectElement,
    specality: HTMLSelectElement)
  {
    event.preventDefault();

    this.http.post<Boolean>(this.backend.backendurl + '/Base/SignUpStudent',
    {
      id: 0,
      name: namefour.value,
      uniqueNumber: +tbc.value,
      gradeNumber: +year.selectedOptions[0].value,
      speciality: +specality.value,
      group: +grouptype.value,
    })
    .subscribe(x =>
    {
      if (x)
      {
        namefour.value = tbc.value = year.value = specality.value = grouptype.value = '';

        alert('تم التسجيل بنجاح');
      }
      else
      {
        alert('لا يمكن التسجيل');
      }
    });
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
