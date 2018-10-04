// laploy course C# programming language
// Indexer example
// indexer is good because I can use [] notatiion

using System;

namespace _00234_Indexer
{
    class SampleCollection<T>
    {
        // Declare an array to store the data elements.
        private T[] arr = new T[100];

        // Define the indexer to allow client code to use [] notation.
        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var myArray = new SampleCollection<string>();
            myArray[0] = "Hello, World";
            myArray[1] = "My name is Loy";
            myArray[2] = "Quick brown fox";
            for(int i = 0; i < 3; i++)
                Console.WriteLine(myArray[i]);
        }
    }
}
/*
Hello, World
My name is Loy
Quick brown fox
*/
