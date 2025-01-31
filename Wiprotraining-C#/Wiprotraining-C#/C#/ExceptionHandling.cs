// /*Exception handling- Exception handling in C# is a technique to handle errors coming when you execute any program.
// It supports the developers in recognizing and managing unforeseen circumstances, keeping the software from crashing. 
// C# assists in making sure that mistakes are handled gracefully and resources are managed appropriately by employing try, catch,
// and, finally, blocks.
// Types of error:
// 1.Commpile time error
// 2.Run time error
// */

// using System;

// namespace Exception_Handling
// {
//     public class ExceptionHandling
//     {
//         public static void Process()
//         {
//             int a;
//             while (true) // Loop until a valid integer is entered
//             {
//                 try
//                 {
//                     Console.Write("Enter Value: ");
//                     a = Convert.ToInt32(Console.ReadLine());
//                     break; // Exit loop if input is valid
//                 }
//                 catch (FormatException)
//                 {
//                     Console.WriteLine("Invalid Input! Please enter a valid integer.");
//                 }
//                 catch (Exception ex) // General exception handling
//                 {
//                     Console.WriteLine($"An unexpected error occurred: {ex.Message}");
//                 }
//                 finally{
//                     Console.WriteLine("Program executed");
//                 }
//             }
//             Console.WriteLine($"Valid Input: {a}");
//         }
//     }

//     class Program
//     {
//         static void Main()
//         {
//             ExceptionHandling.Process();
//         }
//     }
// }
