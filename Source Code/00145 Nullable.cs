// laploy course C# programming language

/*
The ?? operator is called the null-coalescing operator. 
It returns the left-hand operand if the operand is not null; 
otherwise it returns the right hand operand.
*/

using System;

namespace _00145_Nullable
{
    class Program
    {
        static int? GetNullableInt()
        {
            return null;
        }

        static string GetStringValue()
        {
            return null;
        }

        static void Main(string[] args)
        {
            int? x = null;

            // Set y to the value of x if x is NOT null; otherwise,
            // if x == null, set y to -1.
            int y = x ?? -1;

            // Assign i to return value of the method if the method's result
            // is NOT null; otherwise, if the result is null, set i to the
            // default value of int.
            int i = GetNullableInt() ?? default(int);

            string s = GetStringValue();
            // Display the value of s if s is NOT null; otherwise, 
            // display the string "Unspecified".
            Console.WriteLine(s ?? "Unspecified");
        }
    }
}

// Unspecified