// Array practice

// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace Wiprotraining_C_
// {
//    internal class Array
//    {
//        //Single dimensional array
//        // Constructor
//        // public Array()
//        // {
//        //     Console.WriteLine("Enter the size of array:");
//        //     int n = Convert.ToInt32(Console.ReadLine());
//        //     int[] a = new int[n];
//        //     Console.WriteLine("Enter the elements of the array:");
//        //     for (int i = 0; i < n; i++)
//        //     {
//        //         a[i] = Convert.ToInt32(Console.ReadLine());
//        //     }
//        //     Console.WriteLine("The elements of the array are:");
//        //     for (int i = 0; i < n; i++)
//        //     {
//        //         Console.WriteLine(a[i]);
//        //     }
//        // }

//        //Multi dimensional array
//        public Array(){
//            Console.WriteLine("Enter the size of row:");
//            int n = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter the size of column");
//            int m = Convert.ToInt32(Console.ReadLine());
//            int[,] a = new int[n, m];
//            Console.WriteLine("Enter the elements of the array:");
//            for (int i = 0; i < n; i++){
//                for (int j = 0; j < m; j++){
//                    Console.Write($"Element at ({i},{j}): ");
//                    a[i, j] = Convert.ToInt32(Console.ReadLine());
//                }
//            }
//            Console.WriteLine("The elements of two dimensional array are:");
//            for(int i=0;i<n;i++){
//                for(int j=0;j<m;j++){
//                    Console.Write(a[i, j]+"\t");
//                }
//                Console.WriteLine();
//            }
//        }

//         // Entry Point (Main method)
//         public static void Main(string[] args)
//        {
//            // Create an instance of the Array class to run the constructor
//            new Array();
//        }
//    }
// }
