using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Collection
{
    public class Galaxy
    {
        public string Name { get; set; }
        public int MegaLightYears { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var myGalaxy = new List<Galaxy>
            {
                new Galaxy() { Name="Tadpole", MegaLightYears=400},
                new Galaxy() { Name="Pinwheel", MegaLightYears=25},
                new Galaxy() { Name="Milky Way", MegaLightYears=0},
                new Galaxy() { Name="Andromeda", MegaLightYears=3}
            };
            foreach (Galaxy g in myGalaxy)
            {
                Console.WriteLine(g.Name + "  " + g.MegaLightYears);
            }
        }
    }
}

// Output:  
//  Tadpole  400  
//  Pinwheel  25  
//  Milky Way  0  
//  Andromeda  3