// using System;
// using System.Collections.Generic;

// namespace System.IO
// {
//     public class Student
//     {
//         public int Roll { get; set; }
//         public string Name { get; set; }
//         public int Age { get; set; }
//         public string Branch { get; set; }

//         public Student(int roll,string name,int age,string branch){
//             Roll=roll;
//             Name=name;
//             Age=age;
//             Branch=branch;
//         }

//         public void CreateFile(){
//             FileStream fs = new FileStream("student.txt", FileMode.Create, FileAccess.Write);
//             StreamWriter sw = new StreamWriter(fs);
//             sw.WriteLine("Roll No:" + Roll);
//             sw.WriteLine("Name:" + Name);
//             sw.WriteLine("Age:" + Age);
//             sw.WriteLine("Branch:" + Branch);
//             sw.Close();
//             fs.Close();
//         }

//         public void ReadFile(){
//             FileStream fs = new FileStream("student.txt", FileMode.Open, FileAccess.ReadWrite);
//             StreamReader sr = new StreamReader(fs);
//             Console.WriteLine(sr.ReadLine());

//         }
//     }
// }

// public class Program{
//     public static void Main(string[] args) {
//         Student st = new Student(1, "Snehil", 23, "CSE");
//         st.CreateFile();
//         st.ReadFile();
//     }
// }