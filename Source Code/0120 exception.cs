using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0120_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal baht = 0;
            Console.Write("Enter value in Baht: ");
            baht = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("USD = " + baht * 40);
        }
    }
}


