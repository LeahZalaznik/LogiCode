import { Routes } from '@angular/router';
import { ContactComponent } from '../Component/contact/contact.component';
import { LoginComponent } from '../Component/login/login.component';
import { AboutComponent } from '../Component/about/about.component';
import { ErrorComponent } from '../Component/error/error.component';
import { CoursesComponent } from '../Component/courses/courses-component.component';
import { NavComponent } from '../Component/nav/nav.component';

export const routes: Routes = [
    {path:'contact', component:ContactComponent,children:[
         {path:'contact/login', component:LoginComponent, title:'הרשמה'},
     ]}
    // {path:'about', component:AboutComponent, title:'אודות'},
  
    // {path:'**', component:ErrorComponent, title:'שגיאה'}
];
