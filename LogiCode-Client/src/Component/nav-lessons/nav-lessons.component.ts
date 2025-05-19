import { Component, OnInit } from '@angular/core';
import { LessonService } from '../../Services/lesson-service.service';
import { Lesson } from '../../Class/Lesson';

@Component({
  selector: 'app-nav-lessons',
  imports: [],
  templateUrl: './nav-lessons.component.html',
  styleUrl: './nav-lessons.component.css'
})
export class NavLessonsComponent implements OnInit{
 lessons : Array<Lesson>=new Array<Lesson>()
  constructor(public ls:LessonService) {
  }
  ngOnInit(): void {
    this.lessons=this.ls.Lessons;
  }
}
