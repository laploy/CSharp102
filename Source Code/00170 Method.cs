// laploy course C# programming language

/*
Passing by Reference vs. Passing by Value

By default, when a value type is passed to a method, a copy is passed instead of the object itself. 
Therefore, changes to the argument have no effect on the original copy in the calling method. 
You can pass a value-type by reference by using the ref keyword. For more information, 
see Passing Value-Type Parameters. For a list of built-in value types, see Value Types Table.

When an object of a reference type is passed to a method, a reference to the object is passed. 
That is, the method receives not the object itself but an argument that indicates the location of the object. 
If you change a member of the object by using this reference, 
the change is reflected in the argument in the calling method, even if you pass the object by value.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00170_Method
{
    // You create a reference type by using the class keyword, 
    // as the following example shows.
    public class SampleRefType
    {
        public int value;
    }
    class Program
    {
        static void Main(string[] args)
        {
            TestRefType();
        }
        /*
        Now, if you pass an object that is based on this type to a method, 
        a reference to the object is passed. 
        The following example passes an object of type SampleRefType to method ModifyObject.
         */
        public static void TestRefType()
        {
            SampleRefType rt = new SampleRefType();
            rt.value = 44;
            ModifyObject(rt);
            Console.WriteLine(rt.value);
        }
        static void ModifyObject(SampleRefType obj)
        {
            obj.value = 33;
        }
    }
}
