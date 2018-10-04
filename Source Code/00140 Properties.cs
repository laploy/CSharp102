// laploy course C# programming language
/*
Expression body definitions
Property accessors often consist of single-line statements that just assign or 
return the result of an expression. You can implement these properties as expression-bodied members. 
Expression body definitions consist of the => symbol 
followed by the expression to assign to or retrieve from the property.

Starting with C# 6, read-only properties can implement the get accessor as an expression-bodied member. 
In this case, neither the get accessor keyword nor the return keyword is used. 
The following example implements the read-only Name property as an expression-bodied member.
*/
using System;

namespace _00140_properties
{
    public class Person
    {
        private string firstName;
        private string lastName;

        public Person(string first, string last)
        {
            firstName = first;
            lastName = last;
        }

        public string Name => $"{firstName} {lastName}";
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Isabelle", "Butts");
            Console.WriteLine(person.Name);
        }
    }
}
// The example displays the following output:
//      Isabelle Butts