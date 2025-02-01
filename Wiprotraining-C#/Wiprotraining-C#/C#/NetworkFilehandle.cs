// using System;
// using System.Collections.Generic;
// using System.IO;

// namespace NetworkLogApp
// {
//     public class NetworkLog
//     {
//         public int Id { get; set; }
//         public int Source { get; set; }
//         public int Destination { get; set; }
//         public string Date { get; set; }
//         public string Status { get; set; }
//         public string Network { get; set; }

//         // Constructor to initialize a NetworkLog object
//         public NetworkLog(int id, int source, int destination, string date, string status, string network)
//         {
//             Id = id;
//             Source = source;
//             Destination = destination;
//             Date = date;
//             Status = status;
//             Network = network;
//         }

//         // Method to read the file and display network logs
//         public void ReadFile()
//         {
//             List<NetworkLog> list = new List<NetworkLog>();
//             FileStream fs = new FileStream("networklog.txt", FileMode.Open, FileAccess.ReadWrite);
//             StreamReader sr = new StreamReader(fs);

//             int id = 0; int src = 0; int dest = 0;
//             string date = ""; string status = ""; string netw = "";

//             while (sr.Peek() > 0)
//             {
//                 string line = sr.ReadLine();
//                 if (line.StartsWith("Id"))
//                 {
//                     string[] s = line.Split(':');
//                     id = int.Parse(s[1]);
//                 }
//                 else if (line.StartsWith("Source"))
//                 {
//                     string[] s = line.Split(':');
//                     src = int.Parse(s[1]);
//                 }
//                 else if (line.StartsWith("Destination"))
//                 {
//                     string[] s = line.Split(':');
//                     dest = int.Parse(s[1]);
//                 }
//                 else if (line.StartsWith("Date"))
//                 {
//                     string[] s = line.Split(':');
//                     date = s[1];
//                 }
//                 else if (line.StartsWith("Status"))
//                 {
//                     string[] s = line.Split(':');
//                     status = s[1];
//                 }
//                 else if (line.StartsWith("Network"))
//                 {
//                     string[] s = line.Split(':');
//                     netw = s[1];
//                 }

//                 if (id != 0 && src != 0 && dest != 0 && date != "" && status != "" && netw != "")
//                 {
//                     list.Add(new NetworkLog(id, src, dest, date, status, netw));
//                     id = 0; src = 0; dest = 0; date = ""; status = ""; netw = "";
//                 }
//             }
//             fs.Close();

//             Console.WriteLine("Id\t\tSource\t\tDestination\t\tDate\t\tStatus\t\tNetwork");
//             foreach (var item in list)
//             {
//                 if(item.Status=="Success"){
//                     Console.WriteLine($"{item.Id}\t\t{item.Source}\t\t{item.Destination}\t\t{item.Date}\t\t{item.Status}\t\t{item.Network}");
//                 }
//             }
//         }
//     }

//     public class Program
//     {
//         public static void Main(string[] args)
//         {
//             // Read the network log from file
//             NetworkLog log = new NetworkLog(0, 0, 0, "", "", "");
//             log.ReadFile();
//         }
//     }
// }
