// laploy course C# programming language

using System;

namespace _00275_Array_of_Object
{
    class foo
    {
        public string name = "hello";
    }
    class Program
    {
        static void Main(string[] args)
        {
            foo[] myFoo = new foo[10];  // create array

            // fill array with object
            for(int i = 0; i < 10; i++)
            {
                foo f = new foo();
                f.name = f.name + i.ToString();
                myFoo[i] = f;
            }

            // iterate array
            foreach (foo f in myFoo)
                Console.WriteLine(f.name);
        }
    }
}
/*
hello0
hello1
hello2
hello3
hello4
hello5
hello6
hello7
hello8
hello9
*/
