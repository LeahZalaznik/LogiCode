import { Component, OnInit } from '@angular/core';
import { Router, RouterLink } from '@angular/router';
import { PersonalAreaService } from '../../Services/personal-area.service';
import { Student } from '../../Class/Student';
import { CommonModule } from '@angular/common';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatMenuModule } from '@angular/material/menu';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-nav',
  standalone: true,
  imports: [
    CommonModule,
    RouterLink,
    MatToolbarModule,
    MatMenuModule,
    MatIconModule,
    MatButtonModule
  ],
  templateUrl: './nav.component.html',
  styleUrl: './nav.component.css'
})
export class NavComponent implements OnInit{
    current$!: Observable<Student | null>;

  constructor(private pas: PersonalAreaService, private router: Router) {}
  ngOnInit(): void {
    this.current$ = this.pas.current$;
  }

  goToLogin() {
    this.router.navigate(['/contact']);
  }

  goToProfile() {
    this.router.navigate(['/personal-area']);
  }

  logout() {
    this.pas.logout();
    this.router.navigate(['/']);
  }
}
