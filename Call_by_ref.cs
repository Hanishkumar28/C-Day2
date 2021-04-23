using System;

class FuncSwap
        {
            void swap(ref int a, ref int b)
            {
                int temp = a;
                a = b;
                b = temp;
                Console.WriteLine("After Swapping");
                Console.WriteLine("A :" + a);
                Console.WriteLine("B :" + b);
            }
            static void Main(string[] args)
            {
                int a;
                Console.WriteLine("Enter the Number A :");
                a = Convert.ToInt32(Console.ReadLine());
                int b;
                Console.WriteLine("Enter the Number B :");
                b = Convert.ToInt32(Console.ReadLine());
                FuncSwap funcswap = new FuncSwap();
                funcswap.swap(ref a,ref  b);
                Console.WriteLine("Before Swapping");
                Console.WriteLine("A :" + a);
                Console.WriteLine("B :" + b);
            }
        }