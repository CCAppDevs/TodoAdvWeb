import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Todo } from './todo';
import { TodoService } from './todo.service';
import { Subject } from 'rxjs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  // list of todoes
  todoList: Todo[] = [];

  todos: Subject<Todo[]> = this.todo.todo$;

  constructor(private todo: TodoService) { }

  ngOnInit() {
    this.todo.getAllTodoes();
  }

  title = 'todoadvweb.client';
}
