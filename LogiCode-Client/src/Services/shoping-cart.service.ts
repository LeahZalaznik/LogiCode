import { Injectable } from '@angular/core';
import { Course } from '../Class/Course';
import { Payment } from '../Class/Payment';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ShopingCartService {

  constructor(public http:HttpClient) { }
  courses:Array<Course> = new Array<Course>
   updatePay(p:Payment){
    this.http.post(`localhost:7150`,p)
  }
}
