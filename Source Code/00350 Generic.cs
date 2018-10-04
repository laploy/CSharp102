// laploy course C# programming language
/*
by using a generic type parameter T you can write a single class that other 
client code can use without incurring the cost or risk of runtime casts or boxing operations
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00350_Generic
{
    // Declare the generic class.
    public class GenericList<T>
    {
        public void Add(T input)
        {
            Console.WriteLine(input);
        }
    }
    class Program
    {
        private class ExampleClass { }
        static void Main(string[] args)
        {
            // Declare a list of type int.
            GenericList<int> list1 = new GenericList<int>();
            list1.Add(123);

            // Declare a list of type string.
            GenericList<string> list2 = new GenericList<string>();
            list2.Add("abc");

            // Declare a list of type ExampleClass.
            GenericList<ExampleClass> list3 = new GenericList<ExampleClass>();
            list3.Add(new ExampleClass());
        }
    }
}

/*
123
abc
_00350_Generic.Program+ExampleClass 
*/
