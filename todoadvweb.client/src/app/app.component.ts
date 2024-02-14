import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Todo } from './todo';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  // list of todoes
  todoList: Todo[] = [];

  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.getAllTodoes();
  }

  getAllTodoes() {
    this.http.get<Todo[]>("/api/Todoes").subscribe(data => {
      console.log(data);
      this.todoList = data;
    });
  }

  addNewTodo() {
    let item: Todo = {
        todoId: 0,
        description: 'Put new items into the list',
        ownerId: '88290c71-694e-443d-b46f-dfebc19e4393',
        completed: false,
        todoUserId: ''
    }

    this.http.post<Todo>("/api/Todoes", item).subscribe(data => {
      this.todoList.push(data);
    });
  }

  title = 'todoadvweb.client';
}
