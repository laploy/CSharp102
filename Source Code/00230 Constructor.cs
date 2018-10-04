// laploy course C# programming language
// use base constructor

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00230_Constructor
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

    public class Manager : Employee
    {
        public Manager(){}

        public Manager(int annualSalary)
            : base(annualSalary)
        {
            //Add further instructions here.
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee a = new Employee();
            Employee e1 = new Employee(30000);
            Employee e2 = new Employee(500, 52);
            Manager myManager1 = new Manager();
            Manager myManager2 = new Manager(4000);

            Console.WriteLine($"Employee a salary = {a.salary}");
            Console.WriteLine($"Employee e1 salary = {e1.salary}");
            Console.WriteLine($"Employee e2 salary = {e2.salary}");
            Console.WriteLine($"Employee myManager1 salary = {myManager1.salary}");
            Console.WriteLine($"Employee myManager2 salary = {myManager2.salary}");
        }
    }
}
/*
Employee a salary = 0
Employee e1 salary = 30000
Employee e2 salary = 26000
Employee myManager1 salary = 0
Employee myManager2 salary = 4000
*/
