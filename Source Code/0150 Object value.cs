using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0150_Object_value
{
    class Foo
    {
        string name;
        public string Name { get => name; set => name = value; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Foo myFoo1 = new Foo();
            myFoo1.Name = "Laploy";
            Foo myFoo2 = new Foo();
            myFoo2.Name = "Alice";

            Console.WriteLine(myFoo1.Name);
            Console.WriteLine(myFoo2.Name);
        }
    }
}

