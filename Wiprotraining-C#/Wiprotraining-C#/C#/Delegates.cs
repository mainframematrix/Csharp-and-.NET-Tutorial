// /*Delegates is a function pointer or reference
// ->Can pass argument as a function
// ->Function callback
// ->It is used to create events
// Types of delegates:
//     1.Single
//     2.Multicast
// Why We Use Delegates in C#?
//     - A delegate in C# is like a function pointer in C/C++, but it's type-safe and object-oriented.
//     - Delegates allow you to pass methods as parameters, enabling flexible and dynamic method invocation.
// */

// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// public delegate void GetReport();  // Delegate declaration

// public class DelegatesDemo
// {
//     public void Get()
//     {
//         Console.WriteLine("Report is generated");
//     }
//     public void GetReport()
//     {
//         Console.WriteLine("Report 1");
//     }
//     public void GetReport2()
//     {
//         Console.WriteLine("Report 2");
//     }
// }

// public class DelegateResult
// {
//     public void Access(GetReport getReport)
//     {
//         getReport();  // Invoking the delegate
//     }
// }

// public class Program
// {
//     static void Main(string[] args)
//     {
//         DelegatesDemo obj = new DelegatesDemo();

//         //Creating a multicast delegate
//         GetReport gr = new GetReport(obj.Get);
//         gr += new GetReport(obj.GetReport);
//         gr += new GetReport(obj.GetReport2);

//         //Directly invoking the multicast delegate
//         gr();

//         Console.WriteLine("\nAccessing via DelegateResult:");

//         //Passing the delegate to another class method
//         DelegateResult result = new DelegateResult();
//         result.Access(gr);  // Passing the delegate instead of the object
//     }
// }
