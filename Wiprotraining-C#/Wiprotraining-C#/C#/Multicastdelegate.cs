using System;

delegate void MyDelegate(string name);

class Program
{
    public static void Greeting(string name)
    {
        Console.WriteLine("Welcome " + name);
    }

    public static void Course(string name)
    {
        Console.WriteLine("Registered for " + name + " course");
    }

    public static void EndNote(string name)
    {
        Console.WriteLine("Thanks for joining " + name);
    }

    static void Main()
    {
        MyDelegate d = Greeting;
        d += Course;
        d += EndNote;

        d("Snehil");
    }
}
