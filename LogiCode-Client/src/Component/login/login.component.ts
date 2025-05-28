import { Component, OnInit } from '@angular/core';
import { Student } from '../../Class/Student';
import { FormsModule } from '@angular/forms';
import { GoogleLoginProvider, GoogleSigninButtonDirective, SocialAuthService, SocialUser } from '@abacritt/angularx-social-login';
import { StudentService } from '../../Services/student.service';
import { PersonalAreaService } from '../../Services/personal-area.service';


@Component({
  selector: 'app-login',
  imports: [FormsModule, GoogleSigninButtonDirective],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent implements OnInit {
  user: SocialUser | null = null;
  registrationData: Student = {
    email: '',
    password: '',
    name: '',
    potoUrl: '',
    provider: 'password',
    providerId: '',
    studentCourses: [],
    studentTasks: [],
    studentLessons: [],
  };
  token: string = '';
  registrationDataForm: Student = {
    email: '',
    password: '',
    name: '',
    potoUrl: '',
    provider: 'password',
    providerId: '',
    studentCourses: [],
    studentTasks: [],
    studentLessons: []
  };

  constructor(private authService: SocialAuthService, private ss: StudentService, private pas: PersonalAreaService) { }

  ngOnInit() {
    this.authService.authState.subscribe((user) => {
      this.user = user;
      if (user) {
        this.registrationData.email = user.email;
        this.registrationData.name = user.name;
        this.token = this.user.idToken;
        this.register();
      }
      console.log('משתמש מחובר:', user);
      this.token = this.user.idToken;
      this.register();
    });
  }



  signOut(): void {
    this.authService.signOut();
    this.user = null;
  }

  add(stud: Student) {

  }
  register() {
    if (!this.token) {
      console.log("the token is emptyyy");
      return
    }
    this.ss.registerWithGoggle(this.token)
      .subscribe(response => {
        this.pas.login(response)
        console.log(response);
      }, error => {
        console.log("oppss", error);
      });

  }
  registerWithPassword() {
    console.log(this.registrationDataForm);
    this.ss.registerWithPassword(this.registrationDataForm)
      .subscribe(response => {
        console.log(response);
      }, error => {
        console.log("oppss", error);
      });

  }
  edit(st: Student) { }
}
