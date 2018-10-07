namespace test
{
    struct Bar
    {
        int a;
        public int A { get => a; set => a = value; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bar myBar = new Bar();
            myBar.A = 123;
        }
    }
}
