
/*
T is available to the nested Node class. When GenericList<T> is instantiated with a concrete type, 
for example as a GenericList<int>, each occurrence of T will be replaced with int.
*/

using System.Collections.Generic;

namespace _00360_Generic
{
    // type parameter T in angle brackets
    public class GenericList<T>
    {
        // The nested class is also generic on T.
        private class Node
        {
            // T used in non-generic constructor.
            public Node(T t)
            {
                next = null;
                data = t;
            }
            private Node next;
            public Node Next
            {
                get { return next; }
                set { next = value; }
            }
            // T as private member data type.
            private T data;
            // T as return type of property.
            public T Data
            {
                get { return data; }
                set { data = value; }
            }
        }
        private Node head;
        // constructor
        public GenericList()
        {
            head = null;
        }
        // T as method parameter type:
        public void AddHead(T t)
        {
            Node n = new Node(t);
            n.Next = head;
            head = n;
        }
        public IEnumerator<T> GetEnumerator()
        {
            Node current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // int is the type argument
            GenericList<int> list = new GenericList<int>();
            for (int x = 0; x < 10; x++)
            {
                list.AddHead(x);
            }
            foreach (int i in list)
            {
                System.Console.Write(i + " ");
            }
            System.Console.WriteLine("\nDone");

            // double is the type argument
            GenericList<double> list2 = new GenericList<double>();
            for (double x = 1; x < 2; x = x + .1)
            {
                list2.AddHead(x);
            }
            foreach (double i in list2)
            {
                System.Console.Write(i + " ");
            }
            System.Console.WriteLine("\nDone");
        }
    }
}

/*
9 8 7 6 5 4 3 2 1 0
Done
1.9 1.8 1.7 1.6 1.5 1.4 1.3 1.2 1.1 1
Done
*/
