using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0110_Fully_Qualified_Names
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

namespace N1    // N1
{
    class C1    // N1.C1
    {
        class C2    // N1.C1.C2
        {
        }
    }
    namespace N2    // N1.N2
    {
        class C2    // N1.N2.C2
        {

        }
    }
}
