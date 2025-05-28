import { Component, OnInit } from '@angular/core';
import { LessonService } from '../../Services/lesson-service.service';
import { Lesson } from '../../Class/Lesson';
import { Router, RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-nav-lessons',
  imports: [RouterOutlet],
  templateUrl: './nav-lessons.component.html',
  styleUrl: './nav-lessons.component.css'
})
export class NavLessonsComponent implements OnInit{
 lessons : Array<Lesson>=new Array<Lesson>()
  constructor(public ls:LessonService, public router:Router) {
  }
  ngOnInit(): void {
    this.lessons=this.ls.Lessons;
  }
   navigateToRoute(lesson:Lesson) {
    this.ls.currentLesson = lesson
    console.log(lesson.id);
    
    this.router.navigate([`Lessons/${lesson.id}`]);
  }
}
