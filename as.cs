using System;

class Dog
    {
        public void Speak()
        {
            Console.WriteLine("Bark !");
        }
    }
    class Class10
    {
        static void Main()
        {
            object o = new Dog();
            Dog dog = o as Dog;
            if (dog != null)
                dog.Speak();
            Console.ReadLine();
        }
    }