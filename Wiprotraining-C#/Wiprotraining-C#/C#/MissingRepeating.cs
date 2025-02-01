// /*
// Missing and Repeating in an Array
// Given an unsorted array of size n. Array elements are in the range of 1 to n. One number from set {1, 2, …n} is missing and one number occurs twice in the array. Find these two numbers.

// Examples: 

// Input: arr[] = {3, 1, 3}
// Output: Missing = 2, Repeating = 3
// Explanation: In the array, 2 is missing and 3 occurs twice 


// Input: arr[] = {4, 3, 6, 2, 1, 1}
// Output: Missing = 5, Repeating = 1
// */

// using System;

// public class MissingAndRepeating
// {
//     public static void Main(string[] args)
//     {
//         int[] arr = { 4, 3, 6, 2, 1, 1 };
//         int n = arr.Length;

//         int repeating = -1, missing = -1;

//         for (int i = 0; i < n; i++)
//         {
//             int absVal = Math.Abs(arr[i]);

//             if (arr[absVal - 1] < 0)
//             {
//                 repeating = absVal;
//             }
//             else
//             {
//                 arr[absVal - 1] = -arr[absVal - 1];
//             }
//         }

//         for (int i = 0; i < n; i++)
//         {
//             if (arr[i] > 0)
//             {
//                 missing = i + 1;
//                 break;
//             }
//         }

//         Console.WriteLine("Missing = " + missing);
//         Console.WriteLine("Repeating = " + repeating);
//     }
// }
