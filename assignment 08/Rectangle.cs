using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_08
{
    internal class Rectangle : Shape
    {
        public double Width;
        public double Height;

        public override double GetArea()
        {
            return Width * Height;
        }
    }
}
