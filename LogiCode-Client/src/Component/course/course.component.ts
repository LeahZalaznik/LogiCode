import { Component, EventEmitter, Output } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CourseService } from '../../Services/course.service';
import { FormsModule } from '@angular/forms';
import { Lesson } from '../../Class/Lesson';
import {MatSidenavModule} from '@angular/material/sidenav';
import {MatButtonModule} from '@angular/material/button';
import { Router, RouterOutlet } from '@angular/router';
import { ShopingCartService } from '../../Services/shoping-cart.service';

@Component({
  selector: 'app-course',
  imports: [CommonModule,FormsModule,MatButtonModule,MatSidenavModule,RouterOutlet],
  templateUrl: './course.component.html',
  styleUrls: ['./course.component.css']
})
export class CourseComponent {
  showFiller = false;
  constructor(public cs:CourseService, public router:Router, public scs:ShopingCartService){

  }
  isSelected = false;
  l:Lesson = new Lesson();
  isBorderExpanded = false;

  onSelect(id?:number) {
    this.l = this.cs.course.Lessons?.find(ls => ls.id == id)!
  }

  expandBorder() {
    this.isBorderExpanded = true;
  }

  shrinkBorder() {
    this.isBorderExpanded = false;
  }
  onAddToCart() {
    if(!this.scs.courses.find(c => c.Id == this.cs.course.Id))
        this.scs.courses.push(this.cs.course)
    this.router.navigate(['/Course/ShopingCart'])
  }
}
