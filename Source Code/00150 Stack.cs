// laploy course C# programming language

/*
The following code example demonstrates several methods of the 
Stack<T> generic class. The code example creates a stack of strings 
with default capacity and uses the Push method to push five 
strings onto the stack. The elements of the stack are enumerated, 
which does not change the state of the stack. The Pop method is 
used to pop the first string off the stack. The Peek method is 
used to look at the next item on the stack, and then the Pop 
method is used to pop it off.

The ToArray method is used to create an array and copy the stack 
elements to it, then the array is passed to the Stack<T> 
constructor that takes IEnumerable<T>, creating a copy of the 
stack with the order of the elements reversed. The elements of 
the copy are displayed.

An array twice the size of the stack is created, and the CopyTo 
method is used to copy the array elements beginning at the middle 
of the array. The Stack<T> constructor is used again to create 
a copy of the stack with the order of elements reversed; thus, 
the three null elements are at the end.

The Contains method is used to show that the string "four" is 
in the first copy of the stack, after which the Clear method 
clears the copy and the Count property shows that the stack is empty.
*/

using System;
using System.Collections.Generic;

class Example
{
    public static void Main()
    {
        Stack<string> numbers = new Stack<string>();
        numbers.Push("one");
        numbers.Push("two");
        numbers.Push("three");
        numbers.Push("four");
        numbers.Push("five");

        // A stack can be enumerated without disturbing its contents.
        foreach (string number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\nPopping '{0}'", numbers.Pop());
        Console.WriteLine("Peek at next item to destack: {0}",
            numbers.Peek());
        Console.WriteLine("Popping '{0}'", numbers.Pop());

        // Create a copy of the stack, using the ToArray method and the
        // constructor that accepts an IEnumerable<T>.
        Stack<string> stack2 = new Stack<string>(numbers.ToArray());

        Console.WriteLine("\nContents of the first copy:");
        foreach (string number in stack2)
        {
            Console.WriteLine(number);
        }

        // Create an array twice the size of the stack and copy the
        // elements of the stack, starting at the middle of the 
        // array. 
        string[] array2 = new string[numbers.Count * 2];
        numbers.CopyTo(array2, numbers.Count);

        // Create a second stack, using the constructor that accepts an
        // IEnumerable(Of T).
        Stack<string> stack3 = new Stack<string>(array2);

        Console.WriteLine("\nContents of the second copy, with duplicates and nulls:");
        foreach (string number in stack3)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\nstack2.Contains(\"four\") = {0}",
            stack2.Contains("four"));

        Console.WriteLine("\nstack2.Clear()");
        stack2.Clear();
        Console.WriteLine("\nstack2.Count = {0}", stack2.Count);
    }
}

/* This code example produces the following output:

five
four
three
two
one

Popping 'five'
Peek at next item to destack: four
Popping 'four'

Contents of the first copy:
one
two
three

Contents of the second copy, with duplicates and nulls:
one
two
three




stack2.Contains("four") = False

stack2.Clear()

stack2.Count = 0
 */
