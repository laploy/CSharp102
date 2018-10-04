// laploy course C# programming language
/*
 The following example demonstrates declaring class fields, constructors, and methods. 
 It also demonstrates object instantiation and printing instance data. 
 In this example, two classes are declared. 
 The first class, Child, contains two private fields (name and age), 
 two public constructors and one public method. 
 The second class, StringTest, is used to contain Main.
 */

using System;

namespace _00100_Class
{
    class Child
    {
        private int age;
        private string name;
        // Default constructor:
        public Child()
        {
            name = "N/A";
        }
        // Constructor:
        public Child(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        // Printing method:
        public void PrintChild()
        {
            Console.WriteLine("{0}, {1} years old.", name, age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create objects by using the new operator:
            Child child1 = new Child("Craig", 11);
            Child child2 = new Child("Sally", 10);

            // Create an object using the default constructor:
            Child child3 = new Child();

            // Display results:
            Console.Write("Child #1: ");
            child1.PrintChild();
            Console.Write("Child #2: ");
            child2.PrintChild();
            Console.Write("Child #3: ");
            child3.PrintChild();
        }
    }
}

/* Output:
    Child #1: Craig, 11 years old.
    Child #2: Sally, 10 years old.
    Child #3: N/A, 0 years old.
*/
