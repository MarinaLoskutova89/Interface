using System;
using Interface;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Quadcopter quadcopter = new Quadcopter();
                IRobot quadcopter2 = new Quadcopter();
                IFlyingRobot quadcopter3 = new Quadcopter();
                IChargeable quadcopter4 = new Quadcopter();

                string? someComponents = string.Join(",", quadcopter.GetComponents());
                Console.WriteLine(someComponents);

                quadcopter.Charge();

                Console.WriteLine(quadcopter2.GetRobotType());
                Console.WriteLine(quadcopter3.GetRobotType());

                Console.WriteLine(quadcopter2.GetInfo());
                Console.WriteLine(quadcopter4.GetInfo());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
