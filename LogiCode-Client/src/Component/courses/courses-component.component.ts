import { Component, OnInit } from '@angular/core';
import { PersonalAreaService } from '../../Services/personal-area.service';
import { StudentCours } from '../../Class/StudentLesson';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-courses',
  imports: [],
  templateUrl: './courses.component.html',
  styleUrl: './courses.component.css'
})
export class CoursesComponent implements OnInit {
  courses!: Array<StudentCours | null>
  constructor(private pas: PersonalAreaService) {

  }
  ngOnInit(): void {
    this.courses = this.pas.getMyCourses();
  }
}
