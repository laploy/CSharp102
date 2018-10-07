using System;

namespace _0110_Struct
{
    struct Bar
    {
        public void Hello()
        {
            Console.WriteLine("Hello");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bar myBar;
            myBar.Hello();
        }
    }
}
