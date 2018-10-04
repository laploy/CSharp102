using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00340_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IPoint p = new Point(2, 3);
            Console.Write("My Point: ");
            Console.WriteLine("x={0}, y={1}", p.x, p.y);
        }
    }

    interface IPoint
    {
        // Property signatures:
        int x {get;set;}
        int y{get;set;}
    }

    class Point : IPoint
    {
        // Fields:
        private int _x;
        private int _y;

        // Constructor:
        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        // Property implementation:
        public int x
        {
            get {return _x;}
            set {_x = value;}
        }

        public int y
        {
            get {return _y;}
            set {_y = value;}
        }
    }
}

// Output: My Point: x=2, y=3

