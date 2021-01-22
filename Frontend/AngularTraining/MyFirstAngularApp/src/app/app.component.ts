import { Component } from '@angular/core';
import { User } from './models/user';
import { UserService } from './user.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'MyFirstAngularApp';
  users: User[] = [];
  counter: number = 0;

  constructor(userService: UserService) {
    userService.getUsers().subscribe(users => {
      this.users = users;
      this.counter = users.length;
    });
  }

/*   addUser() {
    let user = new User();
    user.firstName = "Athul";
    user.name = "Raj" + Math.random();
    user.age = 28;
    this.users.push(user);
  } */

  onNameChanged() {
    if (this.users.length != this.counter) {
      this.counter += 1;
    }
  }
}
