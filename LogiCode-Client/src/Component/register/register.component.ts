import { Component } from '@angular/core';
import { Student } from '../../Class/Student';
import { StudentService } from '../../Services/student.service';
import { PersonalAreaService } from '../../Services/personal-area.service';
import { GoogleLoginProvider, GoogleSigninButtonDirective, SocialAuthService, SocialUser } from '@abacritt/angularx-social-login';
import { FormsModule } from '@angular/forms';
@Component({
  selector: 'app-register',
  imports: [FormsModule,GoogleSigninButtonDirective],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent {
  user: SocialUser | null = null;
  registrationData: Student = {
    email: '',
    password: '',
    name: ''
  };
  token: string = '';
  registrationDataForm: Student = {
    email: '',
    password: '',
    name: ''
  };

  constructor(private authService: SocialAuthService, private ss: StudentService,private pas:PersonalAreaService) { }

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
    console.log('hkjnl');

    this.ss.registerWithPassword(this.registrationDataForm)
      .subscribe(response => {
        console.log(response);
      }, error => {
        console.log("oppss", error);
      });

  }
  edit(st: Student) { }
}

