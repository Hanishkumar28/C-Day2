using System;


class Palindrome
    {
        static void Main()
        {
            string palind;
            Console.WriteLine("Enter the Palindrome :");
            palind = Console.ReadLine();
            char[] revArray = new char[palind.Length];
            Console.WriteLine(palind);
            for (int i= palind.Length-1; i>=0; i--)
            {
                revArray[i] = palind[i];
            }
            string revpalind = new string(revArray);
            Console.WriteLine(revpalind);
            if (revpalind==palind)
            {
                Console.WriteLine("It is Palindrome");
            }
            else
            {
                Console.WriteLine("It is not a Palindrome");
            }
        }
    }