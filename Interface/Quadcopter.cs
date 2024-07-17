using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Quadcopter : IFlyingRobot, IChargeable
    {
        private readonly List<string> _components = new List<string> { "rotor1", "rotor2", "rotor3", "rotor4" };

        public List<string> GetComponents() 
        {
            return _components;
        }
        public void Charge() 
        {
            Console.WriteLine("Charging...");
            Thread.Sleep(3000);
            Console.WriteLine("Charged!");
        }
        string IChargeable.GetInfo() => "Info from IChargeable!";
        string IRobot.GetInfo() => "Info from IRobot!";
    }
}
