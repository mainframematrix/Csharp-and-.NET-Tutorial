// /*Create a new C # project with three classes plus another class to test the logic in your code. The main classes of the program are the following classes:

// 1.Person
// 2.Student
// 3.Professor
// The Student and Teacher classes inherit from the Person class.

// The Student class will include a public Study() method that will write I'm studying on the screen.

// The Person class must have two public methods Greet() and SetAge(int age) that will assign the age of the person.

// The Teacher class will include a public Explain() method that will write I'm explaining on the screen.

// Also create a public method ShowAge() in the Student class that writes My age is: x years old on the screen.

// You must create another test class called StudentProfessorTest with a Main method to do the following:

// Create a new Person and make him say hello
// Create a new Student, set an age, say hello, and display her age on the screen.
// Create a new Teacher, set an age, say hello and start the explanation.*/

// using System;

// public class  Person{
//     protected int Age;
//     public void Greet(){
//         Console.WriteLine("Hello!");
//     }
//     public void SetAge(int age){
//         Age = age; 
//     }
// }

// public class Student: Person{
//     public void Study(){
//         Console.WriteLine("I'm studying on the screen.");
//     }
//     public void ShowAge(){
//         Console.WriteLine("My age is"+" "+Age+" "+"years old");
//     }

// }

// public class Professor: Person{
//     public void Explain(){
//         Console.WriteLine("I'm explaining on Screen.");
//     }
// }

// public class StudentProfessorTest(){
//     public static void Main(string[] args){
//         Person p = new Person();
//         p.Greet();
//         Student s = new Student();
//         s.SetAge(21);
//         s.Greet();
//         s.ShowAge();
//         s.Study();
//         Professor pr = new Professor();
//         pr.SetAge(40);
//         pr.Greet();
//         pr.Explain();
//     }
// }