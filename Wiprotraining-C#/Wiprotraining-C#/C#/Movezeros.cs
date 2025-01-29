/* Program to create an array and take numbers as a input, the zeros in the array should be moved to the end
For Example:- Input array:[1,0,0,2,3,4,0,5,0] Output array: [1,2,3,4,5,0,0,0,0] */

// using System;
// using System.Reflection;

// namespace Wiprotraining_C_{
//     class Movezeros{
//         public static void Main(string[] args){
//             Console.Write("Enter the size of the array: \t");
//             int n = Convert.ToInt32(Console.ReadLine());
//             int[] arr = new int[n];
//             for(int i=0; i<n; i++){
//                 Console.Write($"Enter the {i+1}st element:\t");
//                 arr[i]= Convert.ToInt32(Console.ReadLine());
//             }
//             MovezerostoEnd(arr,n);
//             Console.Write("Output array: \t");
//             foreach(int ele in arr){
//                 Console.Write(ele+" ");
//             }
//         }
//         static void MovezerostoEnd(int[] arr, int n)
//         {
//             int index=0;
//             for(int i=0; i<n; i++){
//                 if(arr[i]!=0){
//                     arr[index++]=arr[i];
//                 }
//             }
//             while(index< n){
//                 arr[index++]=0;
//             }
//         }
//     }
// }