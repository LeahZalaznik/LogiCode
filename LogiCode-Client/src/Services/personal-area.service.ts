import { Injectable } from '@angular/core';
import { Student } from '../Class/Student';
import { BehaviorSubject, Observable } from 'rxjs';
import { StudentCours, StudentLesson } from '../Class/StudentLesson';
import { Task } from '../Class/Task';

@Injectable({
  providedIn: 'root'
})
export class PersonalAreaService {
  currentUserSubject = new BehaviorSubject<Student | null>(null);
  current$ = this.currentUserSubject.asObservable()
  setCurrentUser(stud: Student) {
    this.currentUserSubject.next(stud)
  }
  get currentUser() {
    return this.currentUserSubject.value
  }
  isLoggedIn(): boolean {
    return !!this.currentUserSubject.value;
  }
  getUser(): Student | null {
    return this.currentUserSubject.value;
  }
  getMyCourses(): Array<StudentCours | null> {
    return this.currentUserSubject.value?.studentCourses ?? []
  }
  getMyLesson(): Array<StudentLesson | null> {
    return this.currentUserSubject.value?.studentLessons ?? []
  }
  addTask(): Array<StudentLesson | null> {
    return this.currentUserSubject.value?.studentLessons ?? []
  }
  getTaskes(): Array<Task | null> {
    return this.currentUserSubject.value?.studentTasks ?? []
  }
  login(user: Student) {
    localStorage.setItem('user', JSON.stringify(user));
    this.currentUserSubject.next(user);
  }
  logout() {
    localStorage.removeItem('user');
    this.currentUserSubject.next(null);
  }
}
