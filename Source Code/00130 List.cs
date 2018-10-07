// laploy course C# programming language

/*
    The following example demonstrates several properties and methods of the List<T> 
    generic class of type string. (For an example of a List<T> of complex types, 
    see the Contains method.)

    The default constructor is used to create a list of strings with the default capacity. 
    The Capacity property is displayed and then the Add method is used to add several items. 
    The items are listed, and the Capacity property is displayed again, 
    along with the Count property, to show that the capacity has been increased as needed.

    The Contains method is used to test for the presence of an item in the list, 
    the Insert method is used to insert a new item in the middle of the list, 
    and the contents of the list are displayed again.

    The default Item[Int32] property (the indexer in C#) is used to retrieve an item, 
    the Remove method is used to remove the first instance of the duplicate item 
    added earlier, and the contents are displayed again. The Remove method always 
    removes the first instance it encounters.

    The TrimExcess method is used to reduce the capacity to match the count, 
    and the Capacity and Count properties are displayed. If the unused capacity had been 
    less than 10 percent of total capacity, the list would not have been resized.

    Finally, the Clear method is used to remove all items from the list, and the Capacity 
    and Count properties are displayed.
*/

using System;
using System.Collections.Generic;

public class Example
{
    public static void Main()
    {
        List<string> dinosaurs = new List<string>();

        Console.WriteLine("\nCapacity: {0}", dinosaurs.Capacity);

        dinosaurs.Add("Tyrannosaurus");
        dinosaurs.Add("Amargasaurus");
        dinosaurs.Add("Mamenchisaurus");
        dinosaurs.Add("Deinonychus");
        dinosaurs.Add("Compsognathus");
        Console.WriteLine();
        foreach (string dinosaur in dinosaurs)
        {
            Console.WriteLine(dinosaur);
        }

        Console.WriteLine("\nCapacity: {0}", dinosaurs.Capacity);
        Console.WriteLine("Count: {0}", dinosaurs.Count);

        Console.WriteLine("\nContains(\"Deinonychus\"): {0}",
            dinosaurs.Contains("Deinonychus"));

        Console.WriteLine("\nInsert(2, \"Compsognathus\")");
        dinosaurs.Insert(2, "Compsognathus");

        Console.WriteLine();
        foreach (string dinosaur in dinosaurs)
        {
            Console.WriteLine(dinosaur);
        }

        // Shows accessing the list using the Item property.
        Console.WriteLine("\ndinosaurs[3]: {0}", dinosaurs[3]);

        Console.WriteLine("\nRemove(\"Compsognathus\")");
        dinosaurs.Remove("Compsognathus");

        Console.WriteLine();
        foreach (string dinosaur in dinosaurs)
        {
            Console.WriteLine(dinosaur);
        }

        dinosaurs.TrimExcess();
        Console.WriteLine("\nTrimExcess()");
        Console.WriteLine("Capacity: {0}", dinosaurs.Capacity);
        Console.WriteLine("Count: {0}", dinosaurs.Count);

        dinosaurs.Clear();
        Console.WriteLine("\nClear()");
        Console.WriteLine("Capacity: {0}", dinosaurs.Capacity);
        Console.WriteLine("Count: {0}", dinosaurs.Count);
    }
}

/* This code example produces the following output:

Capacity: 0

Tyrannosaurus
Amargasaurus
Mamenchisaurus
Deinonychus
Compsognathus

Capacity: 8
Count: 5

Contains("Deinonychus"): True

Insert(2, "Compsognathus")

Tyrannosaurus
Amargasaurus
Compsognathus
Mamenchisaurus
Deinonychus
Compsognathus

dinosaurs[3]: Mamenchisaurus

Remove("Compsognathus")

Tyrannosaurus
Amargasaurus
Mamenchisaurus
Deinonychus
Compsognathus

TrimExcess()
Capacity: 5
Count: 5

Clear()
Capacity: 5
Count: 0
 */
