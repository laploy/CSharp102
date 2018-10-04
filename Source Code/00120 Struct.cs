// laploy course C# programming language
/*
his example demonstrates a feature that is unique to structs. 
It creates a CoOrds object without using the new operator. 
If you replace the word struct with the word class, the program will not compile. 
*/

using System;

namespace _00120_Struct
{
    public struct CoOrds
    {
        public int x, y;

        public CoOrds(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Declare an object:
            CoOrds coords1;

            // Initialize:
            coords1.x = 10;
            coords1.y = 20;

            // Display results:
            Console.Write("CoOrds 1: ");
            Console.WriteLine("x = {0}, y = {1}", coords1.x, coords1.y);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
// // Output: CoOrds 1: x = 10, y = 20