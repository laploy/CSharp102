// laploy course C# programming language
/*
Starting with C# 7.0, both the get and the set accessor can be implemented as expression-bodied members. 
In this case, the get and set keywords must be present. 
The following example illustrates the use of expression body definitions for both accessors. 
Note that the return keyword is not used with the get accessor.
*/
using System;

namespace _00150_Properties
{
    public class SaleItem
    {
        string name;
        decimal cost;

        public SaleItem(string name, decimal cost)
        {
            this.name = name;
            this.cost = cost;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public decimal Price
        {
            get => cost;
            set => cost = value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var item = new SaleItem("Shoes", 19.95m);
            Console.WriteLine($"{item.Name}: sells for {item.Price:C2}");
        }
    }
    // The example displays output like the following:
    //       Shoes: sells for $19.95
}
