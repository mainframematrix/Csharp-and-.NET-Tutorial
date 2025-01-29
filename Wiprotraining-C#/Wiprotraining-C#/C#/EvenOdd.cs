/* Program to create and array and store numbers into it and then seperate the odd no and even no into a jagged array seperately.*/

// using System;

// namespace Wiprotraining_C_
// {
//     class EvenOdd
//     {
//         public static void Main(string[] args)
//         {
//             Console.Write("Enter the size of array:");
//             int n = Convert.ToInt32(Console.ReadLine());
//             int[] arr = new int[n];
//             int evencount = 0;
//             int oddcount = 0;
//             Console.WriteLine("Enter the elements of array:");
//             for (int i = 0; i < n; i++)
//             {
//                 Console.Write($"Element-{i}:");
//                 arr[i] = Convert.ToInt32(Console.ReadLine());
//             }
//             for (int i = 0; i < n; i++)
//             {
//                 if (arr[i] % 2 == 0)
//                 {
//                     evencount++;
//                 }
//                 else
//                 {
//                     oddcount++;
//                 }
//             }
//             int[][] jaggedArray = new int[2][];
//             jaggedArray[0] = new int[evencount];
//             jaggedArray[1] = new int[oddcount];
//             int evenIndex = 0, oddIndex = 0;
//             for (int i = 0; i < n; i++)
//             {
//                 if (arr[i] % 2 == 0)
//                 {
//                     jaggedArray[0][evenIndex] = arr[i];
//                     evenIndex++;
//                 }
//                 else
//                 {
//                     jaggedArray[1][oddIndex] = arr[i];
//                     oddIndex++;
//                 }
//             }
//             Console.WriteLine("The even elements are:");
//             if (evencount == 0)
//             {
//                 Console.WriteLine("No even elements found.");
//             }
//             else
//             {
//                 foreach (int num in jaggedArray[0])
//                 {
//                     Console.Write(num + " ");
//                 }
//                 Console.WriteLine(); 
//             }
//             Console.WriteLine("The odd elements are:");
//             if (oddcount == 0)
//             {
//                 Console.WriteLine("No odd elements found.");
//             }
//             else
//             {
//                 foreach (int num in jaggedArray[1])
//                 {
//                     Console.Write(num + " ");
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }
// }