import { Component } from '@angular/core';
import { ManagerService } from '../manager.service';
import { HttpClient } from '@angular/common/http';
import { Student } from '../student'
import { TypeOfLearn } from '../type-of-learn';
import { Gradeofyear } from '../gradeofyear';
import { Router } from '@angular/router';
import { CaptchaVessel } from '../captcha-vessel';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrl: './signup.component.css'
})
export class SignupComponent {
  public CaptchaVessel: CaptchaVessel;

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

    this.http.get<boolean>(`${this.backend.backendurl}/Base/CheckSignedIn/${localStorage.getItem('Name')}/${localStorage.getItem('Password')}`)
      .subscribe(x => {
        if (x) {
          router.navigateByUrl('/');
        }
      });

      this.http.get<CaptchaVessel>(`${this.backend.backendurl}/Base/GenerateCaptcha/`)
      .subscribe(x => this.CaptchaVessel = x);
  }

  SubmitAccount(event: SubmitEvent,
    namefour: HTMLInputElement,
    tbc: HTMLInputElement,
    grouptype: HTMLInputElement,
    year: HTMLSelectElement,
    specality: HTMLSelectElement,
    EnteredCaptcha: HTMLInputElement,
    password: HTMLInputElement)
  {
    event.preventDefault();

    if (namefour.value.split(' ').length < 4)
    {
      alert('يجب ان يكون الاسم رباعي');
      return;
    }

    if (password.value.length < 8)
    {
      alert('يجب عليك كتابة كلمة سر قوية');
      return;
    }

    if (EnteredCaptcha.value !== this.CaptchaVessel.text)
    {
      alert('رمز التاكيد خاطئ');
      return;
    }

    if (specality.value == 'التخصص' || year.value == 'العام الدراسي' || namefour.value.length == 0 || tbc.value == null || year.value.length == 0)
    {
      alert('يرجي ملئ البيانات كلها');
    }

    this.http.post<Boolean>(this.backend.backendurl + '/Base/SignUpStudent/',
    {
      id: 0,
      name: namefour.value,
      password: password.value,
      uniqueNumber: +tbc.value,
      gradeNumber: +year.value,
      speciality: +specality.value,
      group: +grouptype.value
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
