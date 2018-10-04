// laploy course C# programming language

using System;

namespace _00160_Method
{

    /*
     Method parameters are enclosed in parentheses and are separated by commas. 
     Empty parentheses indicate that the method requires no parameters. 
     This class contains four methods:
     */
    abstract class Motorcycle
    {
        // Anyone can call this.
        public void StartEngine() {/* Method statements here */ }

        // Only derived classes can call this.
        protected void AddGas(int gallons) { /* Method statements here */ }

        // Derived classes can override the base class implementation.
        public virtual int Drive(int miles, int speed) { /* Method statements here */ return 1; }

        // Derived classes must implement this.
        public abstract double GetTopSpeed();
    }


    /*
     Method Access
        Calling a method on an object is like accessing a field. 
        After the object name, add a period, the name of the method, and parentheses. 
        Arguments are listed within the parentheses, and are separated by commas. 
        The methods of the Motorcycle class can therefore be called as in the following example:
     */

    class TestMotorcycle : Motorcycle
    {

        public override double GetTopSpeed()
        {
            return 108.4;
        }

        static void Test()
        {
            TestMotorcycle moto = new TestMotorcycle();
            moto.StartEngine();
            moto.AddGas(15);
            moto.Drive(5, 20);
            double speed = moto.GetTopSpeed();
            Console.WriteLine("My top speed is {0}", speed);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
