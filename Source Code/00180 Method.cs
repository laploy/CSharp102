// laploy course C# programming language

using System;

namespace _00180_Method
{
    class Point
    {
        int x;
        int y;
        public Point(int x, int y) { }
    }
    class Program
    {
        string  First, Last;
        int x, y = 0;
        static void Main(string[] args)
        {
        }

        /*
        Expression Body Definitions
        It is common to have method definitions that simply return immediately 
        with the result of an expression, 
        or that have a single statement as the body of the method. 
        There is a syntax shortcut for defining such methods using =>:
        */

        // Method returning an expression
        public Point Move(int dx, int dy) => new Point(x + dx, y + dy);

        public void Print() => Console.WriteLine(First + " " + Last);

        // Declare and init var using Expression body
        public string Name => First + " " + Last;
    }
}
