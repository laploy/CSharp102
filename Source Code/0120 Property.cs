using System;

namespace _0120_Property
{
    class Foo
    {
        public int a = 0; 
        private int b = 1;  
        public int B { get => b; set => b = value; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Foo myFoo = new Foo();
            Console.WriteLine(myFoo.B);
            // Access class field via property is good.
        }
    }
}
