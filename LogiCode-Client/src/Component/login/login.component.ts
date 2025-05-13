import { Component, OnInit } from '@angular/core';
import { Student } from '../../Class/Student';
import { FormsModule } from '@angular/forms';
import { GoogleLoginProvider, SocialAuthService, SocialUser } from '@abacritt/angularx-social-login';

@Component({
  selector: 'app-login',
  imports: [FormsModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent implements OnInit {
  user: SocialUser | null = null;
  registrationData: Student = {
    email: '',
    password: '',
    name: ''
  };

  constructor(private authService: SocialAuthService) {}

  ngOnInit() {
    this.authService.authState.subscribe((user) => {
      this.user = user;
      console.log('משתמש מחובר:', user);
    });
  }

  signInWithGoogle(): void {
    this.authService.signIn(GoogleLoginProvider.PROVIDER_ID);
    
  }

  signOut(): void {
    this.authService.signOut();
    this.user = null;
  }

  add(stud: Student) {}
  register() {}
  edit(st: Student) {}
}
