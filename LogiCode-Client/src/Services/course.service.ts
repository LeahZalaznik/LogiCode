import { Injectable } from '@angular/core';
import { Course, eLevel } from '../Class/Course';
import { Lesson } from '../Class/Lesson';
import { Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CourseService {

  baseUrl:string = ""
  constructor() {
    this.course = new Course(5,'פייתון למתחילים','פה צריך להיות כתוב המון דברים על \n הקורס הזה כמה ...........................\n.................................\n',
    'python',50,eLevel.easy,0,'assets/image.png',['כיף','מאד','כדאי','לכם','מאד'],[new Lesson(
      5,'cccc')]
  )
}
private navToggleSubject = new Subject<void>();
  navToggle$ = this.navToggleSubject.asObservable();

  toggleNav() {
    this.navToggleSubject.next();
  }
  course!:Course
}
