import { Injectable } from '@angular/core';
import { Student } from '../Class/Student';

@Injectable({
  providedIn: 'root'
})
export class StudentService {

  constructor() { 
    this.list.push(this.s);
  }
  s: Student = new Student(1, "l0583280864@gmail.com", "1234")
  list:Array<Student>=new Array<Student>()
}
