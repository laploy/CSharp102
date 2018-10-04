// laploy course C# programming language

namespace _00352_Generic
{
    class Program
    {
        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            string s1 = "a";
            string s2 = "b";

            // work with int
            Swap<int>(ref a, ref b);
            System.Console.WriteLine(a + " " + b);

            // work with string
            Swap<string>(ref s1, ref s2);
            System.Console.WriteLine(s1 + " " + s2);
        }
    }
}

/*
2 1
b a
*/
