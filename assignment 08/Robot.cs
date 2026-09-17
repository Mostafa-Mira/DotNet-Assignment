using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_08
{
    internal class Robot : IWalkable
    {
        public void Walk()
        {
            Console.WriteLine("Robot Walk");
        }

        void IWalkable.Walk()
        {
            Console.WriteLine("IWalkable Walk");
        }
    }
}
