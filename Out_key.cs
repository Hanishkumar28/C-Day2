using System;

class Out_key
    {
        void Swap(out int a, ref int b)
        {
            Console.WriteLine("In Call By Fuction");
            Console.WriteLine("Enter the out value for A :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A :" + a);
            Console.WriteLine("B :" + b);
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enrter the value for A :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enrter the out value for B :");
            b = Convert.ToInt32(Console.ReadLine());
            Out_key funcout = new Out_key();
            funcout.Swap(out a, ref b);
            Console.WriteLine("In Main Function");
            Console.WriteLine("A :" + a);
            Console.WriteLine("B :" + b);
        }
    }