using System;
using System.IO;

namespace _0120_Write_file
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"d:\temp\MyTest2.txt";
            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("Hello. My name is Laploy.");
            }
        }
    }
}
