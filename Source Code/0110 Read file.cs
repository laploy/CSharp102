using System;
using System.IO;

namespace _0110_Read_file
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
                // Open the file to read from.
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                    // You do NOT need to call Flush() or Close().
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
