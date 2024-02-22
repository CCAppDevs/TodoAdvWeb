import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { TodoService } from '../todo.service';
import { Todo } from '../todo';

@Component({
  selector: 'app-todo-form',
  templateUrl: './todo-form.component.html',
  styleUrls: ['./todo-form.component.css']
})
export class TodoFormComponent implements OnInit {

  todoForm: FormGroup = this.fb.group({
    todoId: [0],
    description: [''],
    completed: [false],
    ownerId: ['88290c71-694e-443d-b46f-dfebc19e4393']
  });

  constructor(private fb: FormBuilder, private data: TodoService) {

  }

  ngOnInit(): void {
        
  }

  onSubmit() {
    console.log(this.todoForm.value);

    let todo: Todo = {
      todoId: 0,
      description: this.todoForm.get('description')?.value,
      ownerId: this.todoForm.get('ownerId')?.value,
      completed: this.todoForm.get('completed')?.value,
      todoUserId: ''
    }

    this.data.createTodo(todo).subscribe(data => {
      console.log(data);
    });
  }

}
