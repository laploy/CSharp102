using System;
using System.IO;

namespace _130_Delete_file
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"d:\temp\MyTest2.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File found.");
                File.Delete(path);
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
