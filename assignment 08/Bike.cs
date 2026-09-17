using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_08
{
    internal class Bike : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Bike Engine Started");
        }

        public void StopEngine()
        {
            Console.WriteLine("Bike Engine Stopped");
        }
    }
}
