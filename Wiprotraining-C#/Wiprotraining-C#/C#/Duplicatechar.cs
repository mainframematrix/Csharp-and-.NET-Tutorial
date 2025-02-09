// /* Find duplicate characters in a string

// Example:
// Here, you can see we have passed "google" as a string, and we got a result as "og".
// It means these two characters (og) are duplicates in the word "google".
// */

// using System;
// using System.Collections.Generic;

// public class Duplicatechars{
//     public static void Main(string[] args){
//         Console.Write("Enter a string: ");
//         string str = Console.ReadLine();
//         Dictionary<char, int> charCount = new Dictionary<char, int>();
//         List<char> duplicateChars = new List<char>();
//         foreach(char c in str){
//             if(charCount.ContainsKey(c)){
//                 charCount[c]++;
//                 if(charCount[c]==2){
//                     duplicateChars.Add(c);
//                 }
//             }
//             else{
//                 charCount[c]=1;
//             }
//         }
//         Console.WriteLine("Duplicate characters: " + string.Join("", duplicateChars));
//     }
// }