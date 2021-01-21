export class User {
    firstName: string = "";
    name: string = "";
    age: number = 0;

    sayHello(): void {
        console.log("Hallo ${this.firstName} ${this.name}");
    }

    countToX(x: number): void {
        for(let index = 0; index <= x; index++)
        {
            console.log(index);
        }
    }
}