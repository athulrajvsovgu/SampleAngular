import { User } from "./user"

console.log("hello world")

let user = new User();
user.firstName = "Athul";
user.name = "Raj";
user.age = 28;

console.log(user);
user.sayHello();
user.countToX(10);