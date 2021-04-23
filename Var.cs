using System;

class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Enter Some Values:");
            var x = Console.ReadLine();
            Console.WriteLine(x);
            Console.WriteLine(x.GetType());
            Console.ReadLine();
        }
    }