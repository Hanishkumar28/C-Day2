using System;

class Class3
    {
        static void Main()
        {
            string a;
            int result;
            Console.WriteLine("Enter the string to be parsed");
            a = Console.ReadLine();
            int.TryParse(a,out result);
            if(result==0)
            {
                Console.WriteLine("Entered is not a number");
            }
            else
            {
                Console.WriteLine("Entered is a number");
            }
            Console.WriteLine(result);
        }
    }