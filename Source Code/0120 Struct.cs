using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0120_Struct
{
    struct Bar
    {
        int a;
        public int A { get => a; set => a = value; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bar myBar = new Bar();
            myBar.A = 123;
            Bar myCopy = myBar;
            myCopy.A = 456;
            Console.WriteLine(myBar.A); // 123
            Console.WriteLine(myCopy.A); // 456
        }
    }
}
