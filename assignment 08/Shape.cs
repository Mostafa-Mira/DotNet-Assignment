using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_08
{
    internal abstract class Shape
    {
        public abstract double GetArea();

        public void Display()
        {
            Console.WriteLine("Shape");
        }
    }
}
