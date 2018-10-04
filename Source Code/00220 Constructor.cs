// laploy course C# programming language
// creat an use class default and params constructor
using System;

namespace _00220_Constructor
{
    public class Employee
    {
        public int salary;

        public Employee() { }

        public Employee(int annualSalary)
        {
            salary = annualSalary;
        }

        public Employee(int weeklySalary, int numberOfWeeks)
        {
            salary = weeklySalary * numberOfWeeks;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee a = new Employee();
            Employee e1 = new Employee(30000);
            Employee e2 = new Employee(500, 52);

            Console.WriteLine($"Employee a salary = {a.salary}");
            Console.WriteLine($"Employee e1 salary = {e1.salary}");
            Console.WriteLine($"Employee e2 salary = {e2.salary}");
        }
    }
}
/*
Employee a salary = 0
Employee e1 salary = 30000
Employee e2 salary = 26000
 */
