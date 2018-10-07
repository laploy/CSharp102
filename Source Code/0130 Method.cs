using System;

namespace _0130_Method
{
    class Foo
    {
        public string GetName()
        {
            return "Laploy";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Foo myFoo = new Foo();
            Console.WriteLine(myFoo.GetName());
        }
    }
}

