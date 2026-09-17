using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_08
{
    internal class Circle : Shape
    {
        public double Radius;

        public override double GetArea()
        {
            return 3.14 * Radius * Radius;
        }
    }
}
