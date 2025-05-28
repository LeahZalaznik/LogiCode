import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { CourseService } from '../../Services/course.service';
import { ShopingCartService } from '../../Services/shoping-cart.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-shoping-cart',
  imports: [CommonModule],
  templateUrl: './shoping-cart.component.html',
  styleUrl: './shoping-cart.component.css'
})
export class ShopingCartComponent {
  isOpen = true;
  constructor(public cs:CourseService,public scs:ShopingCartService,public router:Router){}
  ngOnInit() {
    this.cs.navToggle$.subscribe(() => {
      this.isOpen = !this.isOpen; // משנה את מצב ה-NAV
    });
  }
  openNav() {
    this.isOpen = true;
  }

  closeNav() {
    this.router.navigate(['/Course'])
    this.isOpen = false;
  }

  toPayment(){
    this.router.navigate(['/Payment'])
  }
}


