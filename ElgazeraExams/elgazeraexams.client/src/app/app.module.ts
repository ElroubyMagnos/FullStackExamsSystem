import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SignupComponent } from './signup/signup.component';
import { SigninComponent } from './signin/signin.component';
import { RouterModule } from '@angular/router';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';
import { HomeComponent } from './home/home.component';
import { GradepageComponent } from './gradepage/gradepage.component';
import { CurrentexamComponent } from './currentexam/currentexam.component';
import { HomelogoutComponent } from './homelogout/homelogout.component';
import { TestselectComponent } from './testselect/testselect.component';

@NgModule({
  declarations: [
    AppComponent,
    SignupComponent,
    SigninComponent,
    HeaderComponent,
    FooterComponent,
    HomeComponent,
    GradepageComponent,
    CurrentexamComponent,
    HomelogoutComponent,
    TestselectComponent
  ],
  imports: [
    AppRoutingModule,
    BrowserModule, HttpClientModule,
    RouterModule.forRoot([
      {path: '', component:HomelogoutComponent},
      {path: 'homelogin', component:HomeComponent},
      {path: 'second/:id', component:GradepageComponent},
      {path: 'signup', component:SignupComponent},
      {path: 'signin', component:SigninComponent},
      {path: 'ce/:spec/:grade/:examid', component:CurrentexamComponent},
      {path: 'testselect/:spec/:grade', component:TestselectComponent}
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
