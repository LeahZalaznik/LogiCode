import { Component,OnInit,Input } from '@angular/core';
import { Course } from '../../Class/Course';
@Component({
  selector: 'courses',
  imports: [],
  templateUrl: './courses.component.html',
  styleUrl: './courses.component.css'
})
export class CoursesComponent  implements OnInit{
courses: Course[]=[
  new Course(0,'','','',0,0,'',0,0),
   new Course(456,'jhgfkhg','jhgk','jhv',58,85,'jhg',40,50)
];
ngOnInit():void{}
  onCardClick(course: Course) {
    console.log('Course clicked:', course)
}
}