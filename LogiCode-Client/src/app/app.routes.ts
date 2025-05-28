import { Routes } from '@angular/router';
import { ContactComponent } from '../Component/contact/contact.component';
import { LoginComponent } from '../Component/login/login.component';
import { AboutComponent } from '../Component/about/about.component';
import { ErrorComponent } from '../Component/error/error.component';
import { CoursesComponent } from '../Component/courses/courses-component.component';
import { NavComponent } from '../Component/nav/nav.component';
import { PersonalAreaComponent } from '../Component/personal-area/personal-area.component';
import { HomeComponent } from '../Component/home/home.component';

export const routes: Routes = [
    { path: '', component: HomeComponent }, // דף הבית
    { path: 'home', component: HomeComponent },
    //   { path: 'allcourses', component: AllCoursesComponent },
    { path: 'personal-area', component: PersonalAreaComponent },
    { path: 'contact', component: ContactComponent, children: [
            { path: 'contact/login', component: LoginComponent, title: 'הרשמה' },
        ]
    },
    { path: 'personal-area', component: PersonalAreaComponent },
     { path: '**', redirectTo: '' }
];
