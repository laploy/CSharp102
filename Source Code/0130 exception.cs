using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0130_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal baht = 0;
            Console.Write("Enter value in Baht: ");
            try
            {
                baht = Convert.ToDecimal(Console.ReadLine());
            }
            catch
            {
                baht = 0;
            }
            Console.WriteLine("USD = " + baht * 40);
        }
    }
}
