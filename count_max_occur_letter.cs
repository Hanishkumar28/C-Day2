using System;


class Class
    {
        static void Main()
        {
            Console.WriteLine("Enter a String :");
            string Sentence;
            Sentence = Console.ReadLine();
            int[] charcount = new int[256];
            int length = Sentence.Length;
  
            for (int i= 0; i < Sentence.Length;i++)
            {
                charcount[Sentence[i]]++;
            }
            int maxcount = -1;
            char character = ' ';

            for (int i = 0; i < length; i++)
            {
                if(maxcount<charcount[Sentence[i]])
                {
                    maxcount = charcount[Sentence[i]];
                    character = Sentence[i];
                }
            }
            Console.WriteLine("The string is : {0}", Sentence);
            Console.WriteLine("The Highest occuring character is " +character+" and count is "+maxcount);
            Console.ReadLine();
        }
    }