// laploy course C# programming language
// method overloading

using System;

namespace _00210_Method
{
    class animal
    {
        public virtual void makeSound()
        {
            Console.WriteLine("Hello");
        }
    }

    class human : animal
    {
    }

    class cat : animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            human myHuman = new human();
            myHuman.makeSound();
            cat myCat = new cat();
            myCat.makeSound();
        }
    }
}
