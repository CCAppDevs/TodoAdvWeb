import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

export interface Todo {
  todoId: number;
  description: string;
  ownerId: string;
  completed: boolean;
  todoUserId: string;
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  // list of todoes
  todoList: Todo[] = [
    {
      todoId: 1,
      description: "Do Stuff",
      ownerId: "Jesse",
      completed: false,
      todoUserId: "Jesse"
    },
    {
      todoId: 2,
      description: "Do More Stuff",
      ownerId: "Jesse",
      completed: false,
      todoUserId: "Jesse"
    },
    {
      todoId: 3,
      description: "Do More More Stuff",
      ownerId: "Jesse",
      completed: false,
      todoUserId: "Jesse"
    }
  ];

  constructor(private http: HttpClient) {}

  ngOnInit() {
  }

  title = 'todoadvweb.client';
}
