// laploy course C# programming language

using System;

namespace _00320_Abstract_class
{
    abstract class foo
    {
        public int x = 123;
        public void test()
        {
            Console.WriteLine("hello");
        }
    }

    class bar: foo
    {
        public int y = 456;
    }

    class Program
    {
        static void Main(string[] args)
        {
            bar myBar = new bar();
            Console.WriteLine(myBar.x);
            Console.WriteLine(myBar.y);
            myBar.test();

            //foo myFoo = new foo();    // can not instantiate abstract class
        }
    }
}
/*
123
456
hello
 */
