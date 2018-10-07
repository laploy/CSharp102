namespace test
{
    // Declare the generic class.
    public class GenericList<T>
    {
        public void Add(T input) { }
    }
    public class ExampleClass { }

    class Program
    {
        static void Main(string[] args)
        {
            // Declare a list of type int.
            GenericList<int> list1 = new GenericList<int>();
            list1.Add(1234);

            // Declare a list of type string.
            GenericList<string> list2 = new GenericList<string>();
            list2.Add("hello");

            // Declare a list of type ExampleClass.
            GenericList<ExampleClass> list3 = new GenericList<ExampleClass>();
            list3.Add(new ExampleClass());
        }
    }
}

