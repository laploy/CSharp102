// laploy course C# programming language

using System;
using System.Collections.Generic;

namespace _00100_Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            Assigment();

            double[] d = { 2, 3, 4 };
            var result = ComputeSumsAnSumOfSquares(d);
            Console.WriteLine(result);

            double[] d2 = { 3, 5, 7 };
            var result2 = ComputeSumsAnSumOfSquares(d2);
            Console.WriteLine(result2);
        }

        static void Assigment()
        {
            /*
            The language supports assignment between tuple types that have the same 
            number of elements, where each right-hand side element can be implicitly 
            converted to its corresponding left-hand side element. Other conversions 
            are not considered for assignments. 
            Let's look at the kinds of assignments that are allowed between tuple types.
            */
            // The 'arity' and 'shape' of all these tuples are compatible. 
            // The only difference is the field names being used.
            var unnamed = (42, "The meaning of life");
            var anonymous = (16, "a perfect square");
            var named = (Answer: 42, Message: "The meaning of life");
            var differentNamed = (SecretConstant: 42, Label: "The meaning of life");
            /*
            The first two variables, unnamed and anonymous do not have semantic names 
            provided for the elements. The field names are Item1 and Item2. The last two variables, 
            named and differentName have semantic names given for the elements. 
            These two tuples have different names for the elements. 
            */

            /*
            All four of these tuples have the same number of elements 
            (referred to as 'cardinality') and the types of those elements are identical. 
            Therefore, all of these assignments work
            */
            unnamed = named;

            named = unnamed;
            // 'named' still has fields that can be referred to
            // as 'answer', and 'message':
            Console.WriteLine($"{named.Answer}, {named.Message}");

            // unnamed to unnamed:
            anonymous = unnamed;

            // named tuples.
            named = differentNamed;
            // The field names are not assigned. 'named' still has 
            // fields that can be referred to as 'answer' and 'message':
            Console.WriteLine($"{named.Answer}, {named.Message}");

            // With implicit conversions:
            // int can be implicitly converted to long
            (long, string) conversion = named;

        }

        private static (int Count, double Sum, double SumOfSquares) ComputeSumsAnSumOfSquares
            (IEnumerable<double> sequence)
        {
            /*
                Tuples as method return values
                One of the most common uses for tuples is as a method return value. 
            */
            var computation = (count: 0, sum: 0.0, sumOfSquares: 0.0);

            foreach (var item in sequence)
            {
                computation.count++;
                computation.sum += item;
                computation.sumOfSquares += item * item;
            }
            return computation;
        }

        private static (double, double, int) ComputeSumAndSumOfSquares2
            (IEnumerable<double> sequence)
        {
            double sum = 0;
            double sumOfSquares = 0;
            int count = 0;

            foreach (var item in sequence)
            {
                count++;
                sum += item;
                sumOfSquares += item * item;
            }
            return (sum, sumOfSquares, count);
        }
    }
}

/*
    42, The meaning of life
    42, The meaning of life
    (3, 9, 29)
    (3, 15, 83)
*/
