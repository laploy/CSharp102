using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0110_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of strings by using a  
            // collection initializer.  
            var salmons = new List<string> { "chinook", "coho", "pink", "sockeye" };

            // Iterate through the list.  
            foreach (var salmon in salmons)
            {
                Console.Write(salmon + " ");
            }
            // Output: chinook coho pink sockeye 

            //iterates through the elements of a collection 
            // by using for instead of foreach
            for (var index = 0; index < salmons.Count; index++)
            {
                Console.Write(salmons[index] + " ");
            }
            // Output: chinook coho pink sockeye
        }
        static void RemoveExample()
        {
            // Create a list of strings by using a  
            // collection initializer.  
            var salmons = new List<string> { "chinook", "coho", "pink", "sockeye" };

            // Remove an element from the list by specifying  
            // the object.  
            salmons.Remove("coho");

            // Iterate through the list.  
            foreach (var salmon in salmons)
            {
                Console.Write(salmon + " ");
            }
            // Output: chinook pink sockeye  
        }
        static void RemoveMany()
        {
            var numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Remove odd numbers.  
            for (var index = numbers.Count - 1; index >= 0; index--)
            {
                if (numbers[index] % 2 == 1)
                {
                    // Remove the element by specifying  
                    // the zero-based index in the list.  
                    numbers.RemoveAt(index);
                }
            }
            // Iterate through the list.  
            // A lambda expression is placed in the ForEach method  
            // of the List(T) object.  
            numbers.ForEach( number => Console.Write(number + " "));
            // Output: 0 2 4 6 8  
        }
    }
}
