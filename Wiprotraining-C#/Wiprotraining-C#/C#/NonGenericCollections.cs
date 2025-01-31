// /*NonGeneric Collections*/

// using System;
// using System.Collections;

// namespace Wiprotraining_C_
// {
//     class Employee
//     {
//         public void CreateDepartment()
//         {
//             ArrayList arr = new ArrayList();
//             arr.Add("HR");
//             arr.Add("Finance");
//             arr.Add("Security");
//             arr.Add("IT");
//             arr.Add("Management");

//             arr.RemoveAt(2);  // Removes "Security"
//             arr[2] = "Law";    // Replaces "IT" with "Law"
//             arr.Insert(3, "Engineering"); // Adds "Engineering" at index 3

//             foreach (string dept in arr)
//             {
//                 Console.WriteLine(dept);
//             }
//             Console.WriteLine("Total Departments: " + arr.Count);
//         }

//         public void CreateBranch()
//         {
//             Stack st = new Stack();
//             st.Push("Bangalore");
//             st.Push("Delhi");
//             st.Push("Mumbai");
//             st.Push("Pune");

//             st.Pop(); // Removes "Pune"
//             Console.WriteLine("Top Element: " + st.Peek()); // Displays "Mumbai"

//             Console.WriteLine("Total Branches: " + st.Count);

//             foreach (string branch in st)
//             {
//                 Console.WriteLine(branch);
//             }

//             string[] branchArray = new string[st.Count];
//             st.CopyTo(branchArray, 0); // Copies elements from stack to array

//             Console.WriteLine("Copied Branches:");
//             Console.WriteLine(string.Join(", ", branchArray));
//         }
//         public void CreateState(){
//             Queue q = new Queue();
//             q.Enqueue(2);
//             q.Enqueue(3);
//             q.Enqueue(4);
//             q.Enqueue(5);

//             q.Dequeue();
//             Console.WriteLine("Front Element: " + q.Peek()); // Displays "5"
//             Console.WriteLine("Total States: " + q.Count);
//             Console.WriteLine("Queue Elements:");
//             foreach (int state in q){
//                 Console.WriteLine(state);
//             }

//             int[] states= new int[q.Count];
//             q.CopyTo(states, 0);
//             Console.WriteLine("Copied States:");
//             Console.WriteLine(string.Join(", ", states));
//         }
//         public void CreateSalary(){
//             SortedList sl= new SortedList();
//             sl.Add("John", 5000);
//             sl.Add("Alice", 6000);
//             sl.Add("Sara",3000);
//             sl.Add("Bob", 7000);

//             Console.WriteLine("The no items in list are: " +sl.Count);
//             Console.WriteLine("The items in list are:");
//             foreach(DictionaryEntry items in sl){
//                 Console.WriteLine(items.Key + " " + items.Value);
//             }

//             sl.Contains("John");
//             sl.Remove("Alice");
//             Console.WriteLine("The items in list are:");
//             sl.SetByIndex(2, 4000);
//             UpdateKey(sl,"John","Johnny");
//             SortedList cloned= (SortedList)sl.Clone();
//             foreach(DictionaryEntry items in sl){
//                 Console.WriteLine(items.Key + " " + items.Value);
//             }
//             Console.WriteLine("The items of cloned list are:");
//             foreach (DictionaryEntry items in cloned)
//             {
//                 Console.WriteLine(items.Key + " " + items.Value);
//             }

//         }

//         static void UpdateKey(SortedList sl, object oldKey, object newKey)
//         {
//             if (sl.ContainsKey(oldKey))
//             {
//                 object value = sl[oldKey]; // Get the value of the old key
//                 sl.Remove(oldKey); // Remove the old key-value pair
//                 sl.Add(newKey, value); // Add a new key with the old value
//             }
//             else
//             {
//                 Console.WriteLine($"Key '{oldKey}' not found.");
//             }
//         }

//         public void CreateBonus(){
//             Hashtable ht = new Hashtable();
//             ht.Add("Alice",1500);
//             ht.Add("Bob", 2000);
//             ht.Add("John", 1000);
//             ht.Add("Sara", 500);
//             Console.WriteLine("The no items in list are: " +ht.Count);
//             Console.WriteLine("The items in list are:");
//             foreach(DictionaryEntry items in ht){
//                 Console.WriteLine(items.Key + " " + items.Value);
//             }
//             ht.Contains("Alice");
//             ht.Remove("Alice");
            
//             Console.WriteLine("The items in updated list are:");
//             foreach (DictionaryEntry items in ht){
//                 Console.WriteLine(items.Key+"   "+items.Value);
//             }
//             Console.WriteLine("Copied items in the list are:");
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Employee emp = new Employee();
//             emp.CreateDepartment();
//             emp.CreateBranch();
//             emp.CreateState();
//             emp.CreateSalary();
//             emp.CreateBonus();
//         }
//     }
// }
