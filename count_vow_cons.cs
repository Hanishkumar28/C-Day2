using System;

class Class5
    {
        static void Main()
        {
            string sent;
            int vowel=0,cons=0;
            Console.WriteLine("Enter a String :");
            sent = Console.ReadLine();
            
            for (int i = 0; i < sent.Length; i++)
            {
                if(sent[i]=='a'|| sent[i] == 'e'|| sent[i] == 'i' || sent[i] == 'o' || sent[i] == 'u')
                {
                    vowel++;
                }  
                else
                {
                    cons++;
                }
            }
            Console.WriteLine("The number vowels in the string is : {0}",vowel);
            Console.WriteLine("The number consonaunts in the string is : {0}", cons);
            Console.ReadLine();
        }
    }