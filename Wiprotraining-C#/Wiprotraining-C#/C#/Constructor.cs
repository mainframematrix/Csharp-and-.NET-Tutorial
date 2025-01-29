// Constructors practice
// using System;
// using System.Collections.Generic;

// namespace Wiprotraining_C_{
//     class Car{
//         public String brand; 
//         public Car(){
//             brand="Toyota";
//         }
//         public void display(){
//             Console.WriteLine("Brand: "+brand);
//         }
//     }
//     class Car1
//     {
//         public String Brand;
//         public Car1(string brand)
//         {
//             Brand = brand;
//         }
//         public void display()
//         {
//             Console.WriteLine("Brand: " + Brand);
//         }
//     }
//     class Car2{
//         public String Brand;
//         public String Model;
//         public Car2(){
//             Brand="Hyundai";
//             Model="i10";
//         }

//         public void display(){
//             Console.WriteLine("Brand: "+Brand);
//             Console.WriteLine("Model: "+Model);
//         }
//     }

//     class Program{
//         static void Main(string[] args){
//             Car cars = new Car();
//             cars.display();
//             Car1 car1 = new Car1("Honda");
//             car1.display();
//             Car2 car2 = new Car2();
//             car2.display();
//         }
//     }
// }

// static constructor
// using System;
// using System.Runtime.CompilerServices;

// public class Program{
//     public static int x=10;
//     public int y=10;
//     public Program(){
//         y=y+10;
//         Console.WriteLine("Program is loading");
//     }
//     static Program()
//     {
//         x=x+20;
//         Console.WriteLine("Static Program is loading");
//     }
//     static void Main(string[] args){
//         Console.WriteLine(x);
//         Program  obj= new Program();
//         Console.WriteLine(obj.y);
//     }
// }