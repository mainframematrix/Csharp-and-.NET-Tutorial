// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         int[] arrayWithDuplicates = { 1,4,2,1,3,1,5,7,6,4,3,5 };

//         // // Method-1
//         // // Create a HashSet to store unique elements
//         // HashSet<int> uniqueElements = new HashSet<int>(arrayWithDuplicates);

//         // // Convert the HashSet back to an array
//         // int[] arrayWithoutDuplicates = new int[uniqueElements.Count];
//         // uniqueElements.CopyTo(arrayWithoutDuplicates);

//         // // Print the array without duplicates
//         // Console.WriteLine("Array without duplicates:");
//         // foreach (int item in arrayWithoutDuplicates)
//         // {
//         //     Console.Write(item + " ");
//         // }


//         // // Method-2
//         // int[] uniqueArray = arrayWithDuplicates.Distinct().ToArray();

//         // Console.WriteLine("Array without duplicates: " + string.Join(", ", uniqueArray));

//         // //Mehtod-3
//         Array.Sort(arrayWithDuplicates);
//         int uniqueCount=1;// //Index to place the next unique elements
//         for (int i = 1; i < arrayWithDuplicates.Length; i++)
//         {
//             if (arrayWithDuplicates[i] != arrayWithDuplicates[i - 1])
//             {
//                 arrayWithDuplicates[uniqueCount] = arrayWithDuplicates[i];
//                 uniqueCount++;
//             }
//         }

//         // //Print unique elements
//         Console.Write("Array without duplicates: ");
//         for (int i = 0; i < uniqueCount; i++)
//         {
//             Console.Write(arrayWithDuplicates[i] + " ");
//         }
//     }
// }
