import { Component, Input } from '@angular/core';
import { Todo } from '../todo';
import { TodoService } from '../todo.service';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-todo-item',
  templateUrl: './todo-item.component.html',
  styleUrls: ['./todo-item.component.css']
})
export class TodoItemComponent {
  @Input() todo: Todo = {
      todoId: 0,
      description: '',
      ownerId: '',
      completed: false,
      todoUserId: ''
  }

  constructor(private data: TodoService) {
    console.log(this.onDelete);
  }

  onDelete() {
    // call the service delete todo function
    this.data.deleteTodo(this.todo.todoId);
  }
}
