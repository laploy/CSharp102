// laploy course C# programming language
// Anonymous examples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00280_Anonymous_Type
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int StandardID { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var v = new { Amount = 108, Message = "Hello" };

            // Rest the mouse pointer over v.Amount and v.Message in the following  
            // statement to verify that their inferred types are int and string.  
            Console.WriteLine(v.Amount + " " + v.Message);

            // ou can create an array of anonymously typed elements by combining an implicitly typed 
            // local variable and an implicitly typed array
            var anonArray = new[] { new { name = "apple", diam = 4 }, new { name = "grape", diam = 1 } };


            // using anonymous type in LINQ

            // crreate Student collection
            IList<Student> studentList = new List<Student>() { 
            new Student() { Id = 1, Name = "John", Age = 18, StandardID = 1 } ,
                new Student() { Id = 2, Name = "Steve",  Age = 21, StandardID = 1 } ,
                new Student() { Id = 3, Name = "Bill",  Age = 18, StandardID = 2 } ,
                new Student() { Id = 4, Name = "Ram" , Age = 20, StandardID = 2 } ,
                new Student() { Id = 5, Name = "Ron" , Age = 21 }};

            // write LINQ query
            var q =
            from s in studentList
            select new { s.Id, s.Name };

            // iterate query
            foreach (var stu in q) // stu is an anonymous type
            {
                Console.WriteLine($"Student Id = {stu.Id} name = {stu.Name}");
            }
        }
    }
}

/*
108 Hello
Student Id = 1 name = John
Student Id = 2 name = Steve
Student Id = 3 name = Bill
Student Id = 4 name = Ram
Student Id = 5 name = Ron
*/
