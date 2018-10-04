// laploy course C# programming language

using System;

namespace _00290_Static_member
{
    class foo
    {
        public static string tilte;
        public string name;
    }

    class Program
    {
        static void Main(string[] args)
        {
            foo myFoo1 = new foo();
            foo myFoo2 = new foo();

            myFoo1.name = "abc";
            myFoo2.name = "def";

            foo.tilte = "hello";

            Console.WriteLine(myFoo1.name);
            Console.WriteLine(myFoo2.name);
            Console.WriteLine(foo.tilte);
        }
    }
}
/*
abc
def
hello
*/
