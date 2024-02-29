import { Component } from '@angular/core';
import { TodoService } from '../todo.service';
import { Todo } from '../todo';
import { ReplaySubject } from 'rxjs';

@Component({
  selector: 'app-highlight',
  templateUrl: './highlight.component.html',
  styleUrls: ['./highlight.component.css']
})
export class HighlightComponent {

  lastTodo: ReplaySubject<number> = new ReplaySubject<number>(10);

  constructor(private data: TodoService) {

  }

}
