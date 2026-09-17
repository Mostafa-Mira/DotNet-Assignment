using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_08
{
    internal class Car : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Car Engine Started");
        }

        public void StopEngine()
        {
            Console.WriteLine("Car Engine Stopped");
        }
    }
}
