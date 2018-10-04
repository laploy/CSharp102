// laploy course C# programming language
/*
Following example demonstrates declaration, instantiation, 
and use of a delegate that can be used to reference methods 
that take an integer parameter and returns an integer value. 
*/
using System;

namespace _00050_Delegate
{
    delegate int NumberChanger(int n);

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
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);

            //calling the methods using the delegate objects
            nc1(25);
            Console.WriteLine("Value of Num: {0}", getNum());
            nc2(5);
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.ReadKey();
        }
    }
}
/*
Value of Num: 35
Value of Num: 175
 */
