using System;
using System.Text;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder s1 = new StringBuilder();
            s1.Append("ab");    // ab
            Console.WriteLine(s1);
            var s2 = s1;
            s2.Append("cd");
            Console.WriteLine(s1);  // abcd
            Console.WriteLine(s2);  // abcd
        }
    }
}


