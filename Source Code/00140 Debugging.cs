// // laploy course C# programming language

using System;
using System.Collections.Generic;

namespace ConsoleApp_FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Galaxy News!");
            IterateThroughList();
            Console.ReadKey();
        }

        private static void IterateThroughList()
        {
            var theGalaxies = new List<Galaxy>
            {
                new Galaxy() { Name="Tadpole", MegaLightYears=400, GalaxyType=new GType('S')},
                new Galaxy() { Name="Pinwheel", MegaLightYears=25, GalaxyType=new GType('S')},
                new Galaxy() { Name="Cartwheel", MegaLightYears=500, GalaxyType=new GType('L')},
                new Galaxy() { Name="Small Magellanic Cloud", MegaLightYears=.2, GalaxyType=new GType('I')},
                new Galaxy() { Name="Andromeda", MegaLightYears=3, GalaxyType=new GType('S')},
                new Galaxy() { Name="Maffei 1", MegaLightYears=11, GalaxyType=new GType('E')}
            };

            foreach (Galaxy theGalaxy in theGalaxies)
            {
                Console.WriteLine(theGalaxy.Name + "  " + theGalaxy.MegaLightYears + ",  " + theGalaxy.GalaxyType.MyGType);
            }
        }
    }

    public class Galaxy
    {
        public string Name { get; set; }
        public double MegaLightYears { get; set; }
        public object GalaxyType { get; set; }
    }

    public class GType
    {
        public GType(char type)
        {
            switch (type)
            {
                case 'S':
                    MyGType = Type.Spiral;
                    break;
                case 'E':
                    MyGType = Type.Elliptical;
                    break;
                case 'l':
                    MyGType = Type.Irregular;
                    break;
                case 'L':
                    MyGType = Type.Lenticular;
                    break;
                default:
                    break;
            }
        }
        public object MyGType { get; set; }
        private enum Type { Spiral, Elliptical, Irregular, Lenticular }
    }
}

/*
 ------ actual output ---------
Welcome to Galaxy News!
Tadpole  400,  ConsoleApp_FirstApp.GType
Pinwheel  25,  ConsoleApp_FirstApp.GType
Cartwheel  500,  ConsoleApp_FirstApp.GType
Small Magellanic Cloud  0.2,  ConsoleApp_FirstApp.GType
Andromeda  3,  ConsoleApp_FirstApp.GType
Maffei 1  11,  ConsoleApp_FirstApp.GType

----- expect to see this --------
Tadpole  400,  Spiral 
Pinwheel  25,  Spiral 
Cartwheel, 500,  Lenticular
Small Magellanic Cloud .2,  Irregular
Andromeda  3,  Spiral
Maffei 1,  Elliptical


 */
