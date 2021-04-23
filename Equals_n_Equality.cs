using System;

class Class
    {
        static void Main()
        {
            object str = "hello";
            char[] values = { 'h', 'e', 'l', 'l', 'o' };
            object str2 = new string(values);
            Console.WriteLine("Using Equality Operator : {0}", (str == str2));
            Console.WriteLine("Using Equals method : {0}", str.Equals(str2));
            Console.ReadLine();
        }
    }