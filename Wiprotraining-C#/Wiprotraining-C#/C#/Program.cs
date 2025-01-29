//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Console.Write("Enter your account number = ");
//int acno=Convert.ToInt32(Console.ReadLine());

//Console.Write("Enter your name = ");
//string name=Console.ReadLine();

//Console.WriteLine("Your account number:" + acno);
//Console.WriteLine("Your Name:" +name);

//string
//string strMyValue = "Hello Visitor";
//Console.WriteLine(strMyValue);
////create a new string instance instead of changing the old one
//strMyValue += "How Are";
//Console.WriteLine(strMyValue);
//strMyValue += "You ??";
//Console.WriteLine(strMyValue);

//stringbuilder
//using System.Text;

//StringBuilder sbMyValue = new StringBuilder("");
//sbMyValue.Append("Hello Visitor");
//Console.WriteLine(sbMyValue);
//sbMyValue.Append("How Are You ??");
//Console.WriteLine(sbMyValue);
//string strMyValue = sbMyValue.ToString();

//Console.WriteLine(strMyValue);

//using System;
//using Product_space;

//namespace AnotherNamespace
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Create a Product instance
//            Product product = new Product();

//            // Set properties
//            product.Name = "Smartphone";
//            product.Description = "High-end device";
//            product.Category = "Electronics";

//            // Set the serial number using the method
//            product.SetSerialNumber("SN56789");

//            // Call the CreateProduct method
//            product.CreateProduct();
//        }
//    }
//}

// using Account_space;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Base Account example
//         Account account = new Account();
//         account.Account_types();

//         Console.WriteLine();
        
//         SBI sbi = new SBI();
//         sbi.Account_types();
        
//         Console.WriteLine();
//     }
// }