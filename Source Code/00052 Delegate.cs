// laploy course C# programming language
/*

Multicasting of a Delegate

Delegate objects can be composed using the "+" operator. 
A composed delegate calls the two delegates it was composed from. 
Only delegates of the same type can be composed. 
The "-" operator can be used to remove a component delegate from a composed delegate.

Using this property of delegates you can create an invocation 
list of methods that will be called when a delegate is invoked. 
This is called multicasting of a delegate. 
The following program demonstrates multicasting of a delegate
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int NumberChanger(int n);

namespace _00052_Delegate
{
    class Program
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            //create delegate instances
            NumberChanger nc;
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);

            num = 10;
            //calling the methods using the delegate objects
            nc1(25);
            Console.WriteLine("Value of Num: {0}", getNum());
            nc2(5);
            Console.WriteLine("Value of Num: {0}", getNum());

            nc = nc1;   // register first method
            nc += nc2;  // register second method

            num = 10;
            //calling multicast
            nc(5);  // call AddNum and MultNum
            Console.WriteLine("Value of Num: {0}", getNum());


            num = 10;
            nc -= nc1;  // unregister first method
            nc(2);  // call MultNum only
            Console.WriteLine("Value of Num: {0}", getNum());
        }
    }
}

/*
Value of Num: 35
Value of Num: 175
Value of Num: 900 
*/
