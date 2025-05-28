import { Component } from '@angular/core';
import { RouterLink, RouterOutlet } from '@angular/router';
import { LessonComponent } from "../Component/lesson/lesson.component";
import { NavLessonsComponent } from "../Component/nav-lessons/nav-lessons.component";
import { NavComponent } from "../Component/nav/nav.component";
import { provideHttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  imports: [RouterLink, RouterOutlet, LessonComponent, NavLessonsComponent, NavComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'LogiCode-Client';
}
