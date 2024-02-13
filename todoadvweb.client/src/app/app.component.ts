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

  title = 'todoadvweb.client';
}
