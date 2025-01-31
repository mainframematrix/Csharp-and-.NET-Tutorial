// /*Write a C# program that performs the following operations using an ArrayList:

// Add five city names to the ArrayList.
// Insert a new city at the second position.
// Remove a city from the list.
// Check if a specific city exists in the ArrayList.
// Sort the cities alphabetically and display them.
// Reverse the order of cities and display the final list.
// Bonus: If the user inputs a city that is not in the list, display a message saying "City not found" before removing it.*/

// using System;
// using System.Collections;
// class City{
//     static void Main(string[] args){
//         ArrayList arrList = new ArrayList();
//         arrList.Add("Bangalore");
//         arrList.Add("Mumbai");
//         arrList.Add("Hyderabad");
//         arrList.Add("Pune");
//         arrList.Add("Delhi");

//         arrList.Insert(1,"Kolkata");
//         arrList.Remove("Delhi");
//         Console.Write("Enter city name to check in the list:"+" ");
//         String city=Console.ReadLine();
//         if (arrList.Contains(city))
//         {
//             Console.WriteLine($"{city} is in the list.");
//         }
//         else
//         {
//             Console.WriteLine($"{city} is not in the list.");
//         }
//         arrList.Sort();
//         arrList.Reverse();
//         Console.WriteLine("Final list:");
//         DisplayArrayList(arrList);

//     }
//     static void DisplayArrayList(ArrayList arrList){
//         foreach(var item in arrList){
//             Console.WriteLine(item);
//         }
//     }
// }