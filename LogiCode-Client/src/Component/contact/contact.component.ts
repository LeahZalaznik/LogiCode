import { Component, OnInit } from '@angular/core';
import { LoginComponent } from "../login/login.component";
import { PersonalAreaService } from '../../Services/personal-area.service';
import { Student } from '../../Class/Student';
import { MatSlideToggleModule } from '@angular/material/slide-toggle';
import { RegisterComponent } from "../register/register.component";
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-contact',
  imports: [FormsModule,LoginComponent, MatSlideToggleModule, RegisterComponent],
  templateUrl: './contact.component.html',
  styleUrl: './contact.component.css'
})
export class ContactComponent implements OnInit {
  ss: Student = {};
  isRegisterMode:boolean=false
  constructor(private ps: PersonalAreaService) {
  }
  ngOnInit(): void {
    this.ss != this.ps.currentUser;
  }
}
