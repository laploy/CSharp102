namespace _0120__object
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
            for(int i = 0; i < myFooArray.Length; i++)
            {
                myFooArray[i] = new Foo();
                myFooArray[i].a = i;
            }
        }
    }
}
