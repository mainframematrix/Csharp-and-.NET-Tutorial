// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace Account_space
// {
//     public class Account
//     {
//         public int AccountNumber { get; set; }
//         public String Name { get; set; }
//         public String Password { get; set; }
//         public String Account_type { get; set; }
//         public virtual void Account_types()
//         {
//             string[] types = { "savings", "current", "corporate" };
//             foreach (string type in types)
//             {
//                 Console.WriteLine(type);
//             }
//         }
//     }
//     public class SBI : Account{
//         public override void Account_types()
//         {
//             string[] types = { "savings", "current", "corporate", "business" };
//             foreach (string type in types)
//             {
//                 base.Account_types();
//                 // Console.WriteLine(type);
//             }
//         }
//     }
// }