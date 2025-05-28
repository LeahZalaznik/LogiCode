import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { GooglePayComponent } from "../google-pay/google-pay.component";
import { ShopingCartService } from '../../Services/shoping-cart.service';
import { Student } from '../../Class/Student';
import { Payment } from '../../Class/Payment';

@Component({
  selector: 'app-payment',
  imports: [FormsModule, CommonModule, ReactiveFormsModule, GooglePayComponent],
  templateUrl: './payment.component.html',
  styleUrl: './payment.component.css'
})
export class PaymentComponent {
  form:FormGroup|undefined
  constructor(public fb:FormBuilder,public scs:ShopingCartService){
    this.form = fb.group({
      "firstName":['',Validators.required],
      "lastName":['',Validators.required],
      "phone":['',Validators.required],
      "email":['',[Validators.required,Validators.email]]
    })
  }
  isOpen:boolean=false
  student:Student = JSON.parse(localStorage.getItem('user')!)
  payMent:Payment = new Payment()
  openPay(){
    this.isOpen=!this.isOpen
  }
  updatePay(){
    for (const course of this.scs.courses) {
      this.payMent.studentId = this.student.id
      this.payMent.courseId = course.Id
      this.payMent.amount = course.Price
      this.scs.updatePay(this.payMent)
    }
     
  }
  get gFirstName(){
    return this.form?.get('firstName')
  }

  get gLastName(){
    return this.form?.get('lastName')
  }

  get gPhone(){
    return this.form?.get('phone')
  }

  get gEmail(){
    return this.form?.get('email')
  }
}
