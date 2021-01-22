import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { User } from '../models/user';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.scss']
})
export class UserComponent implements OnInit {
  @Input() public user: User;
  @Output() public nameChanged: EventEmitter<User> = new EventEmitter<User>();

  constructor() {
  }

  ngOnInit(): void {
  }

  changeName(): void {
    this.user.firstName ? this.user.firstName += "!" : this.user.firstName = "!";
    this.nameChanged.emit(this.user);
  }
}
