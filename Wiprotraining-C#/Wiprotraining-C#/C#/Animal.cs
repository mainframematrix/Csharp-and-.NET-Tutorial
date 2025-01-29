// /*Create a C# program that implements abstract class Animal that has a name property of string type and three methods SetName(string name)
// , GetName(string name) and Eat. Eat method will be abstract type
// You need to create a dog class that implements Animal class and the Eat method that says dog is eating.
// Ask the user for a dog name and create a new dog type object from the main of the program give the dog object a name, and then excecute all the mehtods*/

// using System;
// using System.Collections.Generic;

// namespace Wiprotraining_C_
// {
//     abstract class Animal
//     {
//         protected string Name;

//         public void SetName(string name)
//         {
//             Name = name;
//         }
//         public string GetName()
//         {
//             return Name;
//         }

//         public abstract void Eat();
//     }

//     class Dog : Animal
//     {
//         public override void Eat()
//         {
//             Console.WriteLine($"{Name} is eating");
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter the dog's name:");
//             string dogName = Console.ReadLine();

//             Dog myDog = new Dog();
//             myDog.SetName(dogName);

//             // Fixed: now GetName returns the dog's name
//             Console.WriteLine("The dog's name is: " + myDog.GetName());
//             myDog.Eat();
//         }
//     }
// }
