// Generic and array
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0120_Generic
{
    class Bangok<T>
    {
        T _value;
        public Bangok(T t)
        {
            // The field has the same type as the parameter.
            this._value = t;
        }
        public void Write()
        {
            Console.WriteLine(this._value);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Use the generic type Test with an int type parameter.
            Bangok<int> test1 = new Bangok<int>(5);
            // Call the Write method.
            test1.Write();
            // Use the generic type Test with a string type parameter.
            Bangok<string> test2 = new Bangok<string>("cat");
            test2.Write();
        }
    }
}
