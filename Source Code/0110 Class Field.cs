using System;

namespace _0110_Class_field
{
    class Foo
    {
        public int a = 0; // public field = bad
        private int b = 1;  // privarte field = good
    }
    class Program
    {
        static void Main(string[] args)
        {
            Foo myFoo = new Foo();
            Console.WriteLine(myFoo.a);
            // directly access to class field is bad.
        }
    }
}

