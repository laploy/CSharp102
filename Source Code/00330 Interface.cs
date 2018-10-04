// laploy course C# programming language

using System;

namespace _00330_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            ImplementationClass foo = new ImplementationClass();
            foo.Test();
        }
    }
}

interface ISampleInterface
{
    void SampleMethod();
}

class ImplementationClass : ISampleInterface
{
    // Explicit interface member implementation: 
    void ISampleInterface.SampleMethod()
    {
        Console.WriteLine("Hello");
    }

    public void Test()
    {
        // Declare an interface instance.
        ISampleInterface obj = new ImplementationClass();

        // Call the member.
        obj.SampleMethod();
    }
}