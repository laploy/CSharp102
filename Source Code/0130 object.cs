namespace _0130_object
{
    class Foo
    {
        public int a;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Foo[] myFooArray = new Foo[3];
            for (int i = 0; i < myFooArray.Length; i++)
            {
                myFooArray[i] = new Foo();
                myFooArray[i].a = i;
            }
            for (int i = 0; i < myFooArray.Length; i++)
            {
                myFooArray[i] = null;
            }
        }
    }
}
