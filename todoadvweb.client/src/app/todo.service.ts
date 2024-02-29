import { Injectable } from '@angular/core';
import { Todo } from './todo';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable, ReplaySubject, Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TodoService {
  todo$: BehaviorSubject<Todo[]> = new BehaviorSubject<Todo[]>([]);
  singleTodo$: BehaviorSubject<Todo | null> = new BehaviorSubject<Todo | null>(null);
  
  constructor(private http: HttpClient) {
    
  }

  // Create
  createTodo(newTodo: Todo) {
    // create a new todo in the database
    this.http.post<Todo>("/api/todoes", newTodo).subscribe(data => {
      let list = this.todo$.getValue();
      list.push(data);
      this.todo$.next(list);
    });
  }

  // Read
  getAllTodoes() {
    // get all todos from the api
    this.http.get<Todo[]>("/api/todoes").subscribe(data => {
      this.todo$.next(data);
    })


  }

  getTodoById(id: number) {
    // get a todo by id
    this.http.get<Todo>("/api/todoes/" + id).subscribe(data => {
      this.singleTodo$.next(data);
    });
  }

  // Update
  updateTodo(id: number, newTodo: Todo) {
    // update a todo with new data
    //this.http.put<Todo>("")
  }

  // delete
  deleteTodo(id: number) {
    this.http.delete("/api/todoes/" + id).subscribe(data => {
      console.log("deleting:", id, data);
      this.getAllTodoes();
    });
  }
}
