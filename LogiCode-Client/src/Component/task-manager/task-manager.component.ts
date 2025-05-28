import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { MatIcon } from '@angular/material/icon';
import { MatCardModule } from '@angular/material/card';
import { MatIconModule } from '@angular/material/icon';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import {
  trigger,
  transition,
  style,
  animate,
  query,
  stagger,
} from '@angular/animations';

import { Task } from '../../Class/Task';
import { Student } from '../../Class/Student';
import { Observable } from 'rxjs';
import { PersonalAreaService } from '../../Services/personal-area.service';
import { TaskService } from '../../Services/task.service';

@Component({
  selector: 'app-task-manager',
  standalone: true,
  imports: [CommonModule, FormsModule, MatIcon,  MatFormFieldModule,MatInputModule,FormsModule,MatCardModule],
  templateUrl: './task-manager.component.html',
  styleUrls: ['./task-manager.component.css'],
  animations: [
    trigger('listAnimation', [
      transition(':enter', [
        query(
          ':enter',
          [
            style({ opacity: 0, transform: 'translateY(-10px)' }),
            stagger(
              100,
              animate(
                '300ms ease-out',
                style({ opacity: 1, transform: 'translateY(0)' })
              )
            )
          ],
          { optional: true }
        )
      ]),
      transition(':leave', [
        animate(
          '300ms ease-in',
          style({ opacity: 0, transform: 'translateX(100px)' })
        )
      ])
    ]),
    trigger('itemAnimation', [
      transition(':enter', [
        style({ opacity: 0, transform: 'scale(0.9)' }),
        animate('200ms ease-out', style({ opacity: 1, transform: 'scale(1)' }))
      ]),
      transition(':leave', [
        animate('200ms ease-in', style({ opacity: 0, transform: 'scale(0.9)' }))
      ])
    ])
  ]
})
export class TaskManagerComponent implements OnInit {
  tasks: Task[] = [];
  newTaskTitle: string = '';
  currentUser$!: Observable<Student | null>;
  current: Student | null = null;
  today: Date = new Date()
  constructor(
    private pas: PersonalAreaService,
    private ts: TaskService,
  ) { }

  ngOnInit(): void {
    this.currentUser$ = this.pas.current$;

    this.currentUser$.subscribe(response => {
      this.current = response;
      this.tasks = (response?.studentTasks ?? []).filter(
        (task): task is Task => task !== null
      );
    });
  }

  addTask() {
    if (!this.current) {
      console.error('Error: user not found');
      return;
    }

    const newTask: Task = {
      title: this.newTaskTitle,
      isCompleted: false,
      createdAt: new Date(),
      studentId: this.current.id
    };

    this.ts.addTask(newTask).subscribe(
      response => {
        this.tasks.push(response);
        this.newTaskTitle = '';
      },
      error => {
        console.error(error);
      }
    );
  }

  toggleTask(task: Task) {
    this.ts.updateTask(task).subscribe(
      response => {
        task.isCompleted = !task.isCompleted;
      },
      error => {
        console.error(error);
        task.isCompleted = !task.isCompleted; // שחזור אם יש שגיאה
      }
    );
  }

  deleteTask(id: number) {
    this.ts.deleteTask(id).subscribe(
      () => {
        this.tasks = this.tasks.filter(task => task.id !== id);
      },
      error => {
        console.error(error);
      }
    );
  }
}
