// laploy course C# programming language
// using LINQ extension method

using System.Linq;

namespace _00190_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 10, 45, 15, 39, 21, 26 };
            var result = ints.OrderBy(g => g);
            foreach (var i in result)
            {
                System.Console.Write(i + " ");
            }
        }
    }
}
//Output: 10 15 21 26 39 45