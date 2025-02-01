// /*
// Second Largest Element in an Array
// Given an array of positive integers arr[] of size n, the task is to find second largest distinct element in the array.

// Note: If the second largest element does not exist, return -1.

// Examples:

// Input: arr[] = [12, 35, 1, 10, 34, 1]
// Output: 34
// Explanation: The largest element of the array is 35 and the second largest element is 34.
// */
// using System;
// using System.Collections.Generic;
// using System.Collections;

// public class SecondLargest{
//     public static void Main(string[] args) {
//         Console.Write("Enter the no elements you want in the array: ");
//         int n=Convert.ToInt32(Console.ReadLine());
//         int[] arr= new int[n];
//         Console.WriteLine("Enter the elements of the array: ");
//         for(int i=0;i<n;i++){
//             arr[i]=Convert.ToInt32(Console.ReadLine());
//         }
//         int max = arr[0];
//         int secondmax = arr[1];
//         for (int i = 2; i < n; i++){
//             if (arr[i] > max) {
//                 secondmax = max;
//                 max = arr[i];
//             }
//             else if (arr[i] > secondmax && arr[i] != max) {
//                 secondmax = arr[i];
//             }
//         }
//         Console.WriteLine("Second largest element: "+secondmax);
//     }
// }