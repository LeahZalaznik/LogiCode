import { Component } from '@angular/core';
import { LoginComponent } from "../login/login.component";
import { MatIcon } from '@angular/material/icon';
import { OrdersComponent } from "../orders/orders.component";
import { FormsModule } from '@angular/forms';
import { CoursesComponent } from "../courses/courses-component.component";
import { ProfileComponent } from "../profile/profile.component";
import { TaskManagerComponent } from "../task-manager/task-manager.component";
import { SupportComponent } from "../support/support.component";

@Component({
  selector: 'personal-area',
  imports: [FormsModule, OrdersComponent, OrdersComponent, CoursesComponent, ProfileComponent, TaskManagerComponent, SupportComponent],
  templateUrl: './personal-area.component.html',
  styleUrl: './personal-area.component.css'
})

export class PersonalAreaComponent {
  selectedTab: string = 'orders';

  selectTab(tab: string) {
    this.selectedTab = tab;
  }
}


