import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Task } from '../Class/Task';
@Injectable({
  providedIn: 'root'
})
export class TaskService {

  private apiUrl = 'https://localhost:7150/api/Task';

  constructor(private http: HttpClient) {}


  getAllTasks(): Observable<any> {
    return this.http.get(this.apiUrl);
  }


  getTaskById(id: number): Observable<any> {
    return this.http.get(`${this.apiUrl}/${id}`);
  }


  addTask(task: Task): Observable<any> {
    return this.http.post(this.apiUrl,task);
  }

 
  updateTask(task: Task): Observable<any> {
    return this.http.put(`${this.apiUrl}/${task.id}`, task);
  }

  deleteTask(id: number): Observable<any> {
    return this.http.delete(`${this.apiUrl}/${id}`);
  }
}
