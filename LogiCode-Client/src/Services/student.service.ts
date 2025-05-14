import { Injectable } from '@angular/core';
import { Student } from '../Class/Student';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class StudentService {
  apiUrl:String=`https://localhost:7150/api/Student`
  constructor(private http:HttpClient) { 
  }
  registerWithGoggle(token:string) : Observable<any>
  {
     const headers = { 'Content-Type': 'text/plain' };
    return this.http.post(`${this.apiUrl}/google`,{token:token})
  }
  registerWithPassword(user:Student) : Observable<any>
  {
    return this.http.post(`${this.apiUrl}/Login`,user)
  }
  s: Student = new Student(1, "l0583280864@gmail.com", "1234")
  list:Array<Student>=new Array<Student>()
}
