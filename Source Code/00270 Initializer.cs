// laploy course C# programming language
/*
Add methods can use the params keyword to take a variable number of arguments 
as shown in the following example. This example demonstrates the custom implementation 
of an indexer as well to initialize a collection using indexes.
*/

using System;
using System.Collections;
using System.Collections.Generic;

namespace ExampleProject
{
    class RudiDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, List<TValue>>>
    {
        private Dictionary<TKey, List<TValue>> myDic = new Dictionary<TKey, List<TValue>>();
        public IEnumerator<KeyValuePair<TKey, List<TValue>>> GetEnumerator() => myDic.GetEnumerator();

        // Implementation for the GetEnumerator method.
        IEnumerator IEnumerable.GetEnumerator() => myDic.GetEnumerator();

        public List<TValue> this[TKey key]
        {
            get => myDic[key];
            set => Add(key, value);
        }
        public void Add(TKey key, params TValue[] values) => Add(key, (IEnumerable<TValue>)values);
        public void Add(TKey key, IEnumerable<TValue> values)
        {
            if (!myDic.TryGetValue(key, out List<TValue> storedValues))
                myDic.Add(key, storedValues = new List<TValue>());

            storedValues.AddRange(values);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RudiDictionary<string, string> myDic1
                = new RudiDictionary<string, string>()
            {
                {"Group1", "Bob", "John", "Mary" },
                {"Group2", "Eric", "Emily", "Debbie", "Jesse" }
            };
            RudiDictionary<string, string> myDic2
                = new RudiDictionary<string, string>()
            {
                ["Group1"] = new List<string>() { "Bob", "John", "Mary" },
                ["Group2"] = new List<string>() { "Eric", "Emily", "Debbie", "Jesse" }
            };

            Console.WriteLine("Using first multi-valued dictionary created with a collection initializer:");
            foreach (KeyValuePair<string, List<string>> myGroup in myDic1)
            {
                Console.WriteLine($"\r\nMembers of group {myGroup.Key}: ");
                foreach (string member in myGroup.Value)
                {
                    Console.WriteLine(member);
                }
            }

            Console.WriteLine("\r\nUsing second multi-valued dictionary created with a collection initializer using indexing:");
            foreach (KeyValuePair<string, List<string>> group in myDic2)
            {
                Console.WriteLine($"\r\nMembers of group {group.Key}: ");

                foreach (string member in group.Value)
                {
                    Console.WriteLine(member);
                }
            }
        }
    }
}

/*
 * Prints:

    Using first multi-valued dictionary created with a collection initializer:

    Members of group Group1:
    Bob
    John
    Mary

    Members of group Group2:
    Eric
    Emily
    Debbie
    Jesse

    Using second multi-valued dictionary created with a collection initializer using indexing:

    Members of group Group1:
    Bob
    John
    Mary

    Members of group Group2:
    Eric
    Emily
    Debbie
    Jesse
 */
