// laploy course C# programming language

/*
This example, an object which implements IEnumerable containing an 
Add method with multiple parameters allows for collection initializers 
with multiple elements per item in the list corresponding to the signature of the Add method.
*/

using System;
using System.Collections;
using System.Collections.Generic;

namespace _00260_Initializer
{

    class FormattedAddresses : IEnumerable<string>
    {
        private List<string> internalList = new List<string>();
        public IEnumerator<string> GetEnumerator() => internalList.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => internalList.GetEnumerator();
        public void Add(
            string firstname, 
            string lastname, 
            string street, 
            string city, 
            string state, 
            string zipcode) 
            => internalList.Add($@"{firstname} {lastname} {street} {city}, {state} {zipcode}");
    }

    class Program
    {
        static void Main(string[] args)
        {
            FormattedAddresses addresses = new FormattedAddresses()
            {
                {"John", "Doe", "123 Street", "Banban", "KS", "10250" },
                {"Jane", "Smith", "456 Street", "Silom", "BKK", "12345" }
            };
            Console.WriteLine("Address Entries:");
            foreach (string addressEntry in addresses)
            {
                Console.WriteLine("\r\n" + addressEntry);
            }
        }
    }
}
/*
Address Entries:

John Doe 123 Street Banban, KS 10250

Jane Smith 456 Street Silom, BKK 12345
*/
