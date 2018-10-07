using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0110_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            int k = 100;
            Console.WriteLine("j = {0}  k = {1}", j, k);
            int x = 0;
            
            try
            {
                x = k / j;
            }
            catch
            {
                Console.WriteLine("something wrong.");
                x = -1;
            }
            finally
            {
                Console.WriteLine("clean up here.");
            }
            Console.WriteLine("x = {0}", x);
        }
    }
}

