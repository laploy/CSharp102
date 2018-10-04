// laploy course C# programming language
// create and use Extension method

using ExtensionMethods;
using System;

namespace _00200_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello Extension Methods";
            int i = s.WordCount();
            Console.WriteLine($"word count = {i}"); // word count = 3
        }
    }
}

namespace ExtensionMethods
{
    public static class MyExtensions
    {
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
