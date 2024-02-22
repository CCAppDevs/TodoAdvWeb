import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Todo } from './todo';
import { TodoService } from './todo.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  // list of todoes
  todoList: Todo[] = [];

  constructor(private todo: TodoService) { }

  ngOnInit() {
    this.todo.getAllTodoes().subscribe((data: Todo[]) => {
      this.todoList = data;
    })
  }

  title = 'todoadvweb.client';
}
