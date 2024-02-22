import { Injectable } from '@angular/core';
import { Todo } from './todo';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TodoService {

  constructor(private http: HttpClient) { }

  // Create
  createTodo(newTodo: Todo): Observable<Todo> {
    // create a new todo in the database
    return this.http.post<Todo>("/api/todoes", newTodo);
  }

  // Read
  getAllTodoes(): Observable<Todo[]> {
    // get all todos from the api
    return this.http.get<Todo[]>("/api/todoes");
  }

  getTodoById(id: number) {
    // get a todo by id
  }

  // Update
  updateTodo(id: number, newTodo: Todo) {
    // update a todo with new data
  }

  // delete
  deleteTodo(id: number) {
    // delete a specific todo
  }
}
