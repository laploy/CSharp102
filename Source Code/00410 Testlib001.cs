// laploy course C# programming language
// Test HardwareTnterface Library

using Laploy.HardwareInterface.InputOutput;

namespace TestLib001
{
    class Program
    {
        static void Main(string[] args)
        {
            ValveTest();
            MotorTest();
        }
        static void ValveTest()
        {
            SolenoidValve myValve1 = new SolenoidValve();
            SolenoidValve myValve2 = new SolenoidValve();
            myValve1.Id = 12;
            myValve1.Name = "Front Valve";
            myValve2.Id = 23;
            myValve2.Name = "Rear Valve";

            myValve1.TurnOn();
            myValve2.TurnOn();

            myValve1.TurnOff();
            myValve2.TurnOff();
        }
        static void MotorTest()
        {
            Motor myMotorA = new Motor();
            myMotorA.Id = 1;
            myMotorA.port = 123;
            myMotorA.Start();
            myMotorA.Stop();

            Motor myMotorB = new Motor();
            myMotorB.Id = 2;
            myMotorB.port = 9000;
            myMotorB.Start();
            myMotorB.Stop();
        }
    }
}

/*
Solinoide Front Valve is turned-on
Solinoide Rear Valve is turned-on
Solinoide Front Valve is turned-off
Solinoide Rear Valve is turned-off
Motor 1 port 123 started
Motor 1 port 123 stoped
Motor 2 port 9000 started
Motor 2 port 9000 stoped 
*/

