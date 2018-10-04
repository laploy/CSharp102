// laploy course C# programming language
/*
In this example, the TimePeriod class represents an interval of time. 
Internally, the class stores the time interval in seconds in a private field named seconds. 
A read-write property named Hours allows the customer to specify the time interval in hours. 
Both the get and the set accessors perform the necessary conversion between hours and seconds. 
In addition, the set accessor validates the data and throws an ArgumentOutOfRangeException 
if the number of hours is invalid.
*/
using System;

namespace _00130_Properties
{
    class TimePeriod
    {
        private double seconds;

        public double Hours
        {
            get { return seconds / 3600; }
            set
            {
                if (value < 0 || value > 24)
                    throw new ArgumentOutOfRangeException(
                          $"{nameof(value)} must be between 0 and 24.");

                seconds = value * 3600;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TimePeriod t = new TimePeriod();
            // The property assignment causes the 'set' accessor to be called.
            t.Hours = 24;

            // Retrieving the property causes the 'get' accessor to be called.
            Console.WriteLine($"Time in hours: {t.Hours}");
        }
    }
}

// The example displays the following output:
//    Time in hours: 24
