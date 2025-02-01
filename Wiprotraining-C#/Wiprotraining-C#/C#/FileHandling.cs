// using System;
// using System.Collections.Generic;

// namespace System.IO
// {
//     public class Transaction
//     {
//         public int Id { get; set; }
//         public string Name { get; set; }
//         public string Description { get; set; }
//         public string Type { get; set; }

//         // Constructor to initialize the transaction details
//         public Transaction(int id, string name, string desc, string type)
//         {
//             Id = id;
//             Name = name;
//             Description = desc;
//             Type = type;
//         }

//         // Method to create a transaction and write to file
//         public void CreateTransaction()
//         {
//             FileStream fs = new FileStream("trans.txt", FileMode.Create, FileAccess.Write); // Create file
//             StreamWriter streamWriter = new StreamWriter(fs);
//             streamWriter.WriteLine("Id:" + Id);
//             streamWriter.WriteLine("Name:" + Name);
//             streamWriter.WriteLine("Desc:" + Description);
//             streamWriter.WriteLine("Type:" + Type);
//             streamWriter.Close();
//             fs.Close();
//         }

//         // Method to read transaction details from file
//         public void ReadTransaction()
//         {
//             List<Transaction> list = new List<Transaction>();

//             FileStream fs = new FileStream("trans.txt", FileMode.Open, FileAccess.Read); // Open file for reading
//             StreamReader sr = new StreamReader(fs);

//             int id = 0;
//             string name = "", desc = "", type = "";
//             while (sr.Peek() > 0)
//             {
//                 string line = sr.ReadLine();
//                 if (line.StartsWith("Id"))
//                 {
//                     string[] s = line.Split(':'); // "Id:1" -> s[0]="Id"  s[1]="1"
//                     id = Convert.ToInt32(s[1]);
//                 }
//                 else if (line.StartsWith("Name"))
//                 {
//                     string[] s = line.Split(':'); // "Name:John" -> s[0]="Name"  s[1]="John"
//                     name = s[1];
//                 }
//                 else if (line.StartsWith("Desc"))
//                 {
//                     string[] s = line.Split(':'); // "Desc:First Credit" -> s[0]="Desc"  s[1]="First Credit"
//                     desc = s[1];
//                 }
//                 else if (line.StartsWith("Type"))
//                 {
//                     string[] s = line.Split(':'); // "Type:Credit" -> s[0]="Type"  s[1]="Credit"
//                     type = s[1];
//                 }

//                 // When all properties are populated, create a TransactionDetails object
//                 if (id != 0 && name != "" && desc != "" && type != "")
//                 {
//                     Transaction t = new Transaction(id, name, desc, type);
//                     list.Add(t);
//                     id = 0;
//                     name = "";
//                     desc = "";
//                     type = "";
//                 }
//             }
//             fs.Close();

//             // Output the transaction details
//             Console.WriteLine("Id\t\tName\t\tDesc\t\tType");
//             foreach (var item in list)
//             {
//                 if (item.Type == "Credit")
//                     Console.WriteLine($"{item.Id}\t\t{item.Name}\t\t{item.Description}\t\t{item.Type}");
//             }
//         }
//     }
// }

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         // Create a transaction instance
//         Transaction transaction = new Transaction(1, "Snehil", "First credit", "Credit");

//         // Create a transaction (write to file)
//         transaction.CreateTransaction();

//         // Read the transaction (read from file)
//         transaction.ReadTransaction();
//     }
// }
