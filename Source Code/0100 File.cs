using System;
using System.IO;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            // path is NOT case sensitive
            string path = @"d:\temp\MyTest.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File found.");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}

