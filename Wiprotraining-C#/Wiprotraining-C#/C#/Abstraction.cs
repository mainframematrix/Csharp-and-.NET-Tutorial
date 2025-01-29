// Abstration practice
// using System;

// namespace Wiprotraining_C_
// {
//     abstract class Vehicle
//     {
//         public abstract void StartEngine();

//         public void StopEngine()
//         {
//             Console.WriteLine("Engine stopped.");
//         }
//     }

//     class Car : Vehicle
//     {
//         public override void StartEngine()
//         {
//             Console.WriteLine("Car engine started.");
//         }
//         public void EngineSound(){
//             Console.WriteLine("Vroom");
//         }
//     }
//     class Car2 : Car{
//         public override void StartEngine()
//         {
//             base.StartEngine();
//         }
//     }
//     class Program
//     {
//         static void Main()
//         {
//             Car myCar = new Car();
//             myCar.StartEngine();  // Output: Car engine started.
//             myCar.StopEngine();
//             myCar.EngineSound();
//             Car2 cars = new Car2();
//             cars.StartEngine();
//             cars.EngineSound();
//         }
//     }

// }