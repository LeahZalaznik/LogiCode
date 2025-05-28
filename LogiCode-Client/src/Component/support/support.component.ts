import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators, ReactiveFormsModule, FormControl } from '@angular/forms';
import emailjs from 'emailjs-com';
import { CommonModule } from '@angular/common';
import { PersonalAreaComponent } from '../personal-area/personal-area.component';
import { PersonalAreaService } from '../../Services/personal-area.service';
import { Student } from '../../Class/Student';
import { Observable } from 'rxjs';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-support',
  standalone: true,
  imports: [ReactiveFormsModule, CommonModule],
  templateUrl: './support.component.html',
  styleUrls: ['./support.component.css']
})
export class SupportComponent implements OnInit {
  myForm: FormGroup = new FormGroup({})
  userProfile$!: Observable<Student | null>
  constructor( private pas: PersonalAreaService,private snackBar:MatSnackBar) { }
  ngOnInit(): void {
    this.userProfile$=this.pas.current$
    this.restartForm()
  }
   get Gemail() {
    return this.myForm.controls['email']
  }
  get name() {
    return this.myForm.controls['name']
  }
 
  get message() {
  return this.myForm.controls['message'];
}
  restartForm() {
    this.userProfile$.subscribe(
      response => {
        console.log(response);
        this.myForm = new FormGroup({
          name: new FormControl(response?.name, [Validators.required]),
          email: new FormControl(response?.email, [Validators.required,Validators.email]),
          message: new FormControl('', [Validators.required])
        })
      },
      error => {
        console.log(error);
      })


  }
  onSubmit(event: Event) {
    if (this.myForm.invalid) {
      this.myForm.markAllAsTouched();
      return;
    }

    emailjs.sendForm(
      'service_4ew8p9k',
      'template_y145fer',
      event.target as HTMLFormElement,
      'XnrSaO8CIVzpCZg3t'
    ).then(() => {
          this.snackBar.open('ההודעה נשלחה בהצלחה!', 'סגור', {
        duration: 3000,
        panelClass: ['success-snackbar']
      });
      this.myForm.reset();
    }, (error) => {
      this.snackBar.open('אירעה שגיאה בשליחה', 'סגור', {
        duration: 3000,
        panelClass: ['error-snackbar']
      });
      console.error(error);
    });

  }
}