import { booleanAttribute, Injectable } from '@angular/core';
import { Student } from '../Class/Student';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class StudentService {
  apiUrl: String = `https://localhost:7150/api/Student`
  constructor(private http: HttpClient) {
  }
  registerWithGoggle(token: string): Observable<any> {
    const headers = { 'Content-Type': 'text/plain' };
    return this.http.post(`${this.apiUrl}/google`, { token: token })
  }
  registerWithPassword(user: Student): Observable<any> {
    return this.http.post(`${this.apiUrl}/Login`, user)
  }
  getAllUsers(): Observable<any> {
    return this.http.get(`${this.apiUrl}`)
  }
  // validate ------------
  passwordValidate(password: string): boolean {

    this.getAllUsers()
      .subscribe(response => {
        this.list=response;
      }, error => {
        console.log("oppss", error);
      });
    if(this.list==null || this.list.length==0 || this.list.find(u=>u.password==password))
      return false;
    return true;
  }
  updateUser(user:Student):Observable<any>{
    return this.http.put(`${this.apiUrl}`,user)
  }
  s: Student = new Student(1, "l0583280864@gmail.com", "1234")
  list: Array<Student> = new Array<Student>()
}
