// laploy course C# programming language

using System;

namespace Laploy.HardwareInterface.InputOutput
{
    public class Motor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int port { get; set; }

        public void Start()
        {
            Console.WriteLine($"Motor {Id} port {port} started");
        }
        public void Stop()
        {
            Console.WriteLine($"Motor {Id} port {port} stoped");
        }
    }
}

// laploy course C# programming language

using System;

namespace Laploy.HardwareInterface.InputOutput
{
    public class SolenoidValve
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void TurnOn()
        {
            Console.WriteLine($"Solinoide {Name} is turned-on");
        }
        public void TurnOff()
        {
            Console.WriteLine($"Solinoide {Name} is turned-off");
        }
    }
}


