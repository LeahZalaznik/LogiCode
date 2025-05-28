import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormControl, FormGroup, FormGroupDirective, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { Student } from '../../Class/Student';
import { Observable } from 'rxjs';
import { PersonalAreaComponent } from '../personal-area/personal-area.component';
import { PersonalAreaService } from '../../Services/personal-area.service';
import { StudentService } from '../../Services/student.service';

@Component({
  selector: 'app-profile',
  imports: [ReactiveFormsModule],
  templateUrl: './profile.component.html',
  styleUrl: './profile.component.css'
})
export class ProfileComponent implements OnInit {
  myForm: FormGroup = new FormGroup({})
  userProfile$!: Observable<Student | null>
  constructor(private pas: PersonalAreaService, private ss: StudentService) {
  }
  ngOnInit(): void {
    this.userProfile$ = this.pas.current$
    this.restartForm()
  }
  get Gemail() {
    return this.myForm.controls['email']
  }
  get name() {
    return this.myForm.controls['name']
  }
  get Gpassword() {
    return this.myForm.controls['password']
  }
  restartForm() {
    this.userProfile$.subscribe(
      response => {
        console.log(response);
        this.myForm = new FormGroup({
          name: new FormControl(response?.name),
          password: new FormControl(response?.password),
          email: new FormControl(response?.email, [Validators.required])
        })
      },
      error => {
        console.log('mk;mk');
        console.log(error);
      })


  }

  checkPassword(e: AbstractControl) {
    console.log(this.ss.passwordValidate(e.value));

    // if (!this.ss.passwordValidate(e.value)) {
    //   this.Gpassword?.setErrors({ 'err': true })
    //   return { 'err': true }
    // }
    this.myForm.controls['password']?.setErrors(null)
    return null;
  }
  updateUser() {
    console.log(this.myForm.valid);
    console.log(this.myForm.value)

    this.ss.updateUser(this.myForm.value).subscribe(
      respone => {
        this.pas.setCurrentUser(respone)
      },
      error => {
        console.log(error);
      }
    )
    this.restartForm()
  }
}