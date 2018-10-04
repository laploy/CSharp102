// laploy course C# programming language

using System;

namespace _00300_Inheritance
{
    class foo
    {
        public int number = 123;
        private int id = 234;
        protected int phone = 876;
        public void action1() => Console.WriteLine("Action1");
        private void action2() => Console.WriteLine("Action2");
        public virtual void action4() => Console.WriteLine("Action4");
        protected virtual void action5() => Console.WriteLine("Action4");
    }
    class bar: foo
    {
        public void action3() => Console.WriteLine("Action3");
        public override void action4()
        {
            base.action4();
            Console.WriteLine("Hello");

        }
        public void test()
        {
            Console.WriteLine(number);
            // Console.WriteLine(id); // can not see private filed
            Console.WriteLine(phone);
            phone = 987;
        }
        // public override void action5() { } // can not override protected method
    }

    class Program
    {
        static void Main(string[] args)
        {
            bar myBar = new bar();
            Console.WriteLine(myBar.number);
            // Console.WriteLine(myBar.id); can not see private filed
            // Console.WriteLine(myBar.phone); can not see protected field

            myBar.action1();
            // myBar.action2(); // can not call private method
            myBar.action3();
            myBar.action4();
            myBar.test();
        }
    }
}
/*
123
Action1
Action3
Action4
Hello
123
876 
*/
