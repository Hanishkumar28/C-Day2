using System;

class Class2
    {
        void checkOddEven(int a)
        {
            if(a%2==0)
            {
                Console.WriteLine("Number is EVEN");
            }
            else
            {
                Console.WriteLine("Number is ODD");
            }
        }
        static void Main(string[] args)
        {
            int b;
            Console.WriteLine("Enter a Number");
            b = Convert.ToInt32(Console.ReadLine());
            Class2 class2 = new Class2();
            class2.checkOddEven(b);
            Console.ReadLine();
        }
    }