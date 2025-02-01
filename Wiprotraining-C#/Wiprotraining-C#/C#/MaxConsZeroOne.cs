// /*
// Maximum consecutive one’s (or zeros) in a binary array
// Given a binary array, find the count of a maximum number of consecutive 1s present in the array.

// Examples : 

// Input: arr[] = {1, 1, 0, 0, 1, 0, 1, 0, 1, 1, 1, 1}
// Output: 4
// Explanation: The maximum number of consecutive 1’s in the array is 4 from index 8-11.


// Input: arr[] = {0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1}
// Output: 1
// Explanation: The maximum number of consecutive 0’s in the array is 1 from index 0-1.
// */
// using System;
// using System.Collections;

// public class MaxConsZeroOne
// {
//     public static void Main(string[] arg)
//     {
//         Console.Write("Enter the size of the array: ");
//         int n = int.Parse(Console.ReadLine());
//         int[] arr = new int[n];
//         Console.WriteLine("Enter the elements of the array: ");
//         for (int s = 0; s < n; s++){
//             arr[s] = int.Parse(Console.ReadLine());
//         }
//         int maxOnes = 0;
//         int maxZeros = 0;

//         // Find max consecutive 1's
//         int i = 0;
//         while (i < n)
//         {
//             if (arr[i] == 1)
//             {
//                 int k = i;
//                 while (k < n && arr[k] == 1)
//                 {
//                     k++;
//                 }
//                 maxOnes = Math.Max(maxOnes, k - i);
//                 i = k;
//             }
//             else
//             {
//                 i++;
//             }
//         }

//         // Find max consecutive 0's
//         int j = 0;
//         while (j < n)
//         {
//             if (arr[j] == 0)
//             {
//                 int k = j;
//                 while (k < n && arr[k] == 0)
//                 {
//                     k++;
//                 }
//                 maxZeros = Math.Max(maxZeros, k - j);
//                 j = k;
//             }
//             else
//             {
//                 j++;
//             }
//         }

//         Console.WriteLine("Max consecutive 1's: " + maxOnes);
//         Console.WriteLine("Max consecutive 0's: " + maxZeros);
//     }
// }
