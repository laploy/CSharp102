// laploy course C# programming language

namespace _00310_Sealed_class
{
    sealed class foo
    {
        int x = 123;
    }

    class bar: foo  // can inherit from sealed class
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
