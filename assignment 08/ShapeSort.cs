using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_08
{
    internal class ShapeSort : IComparable
    {
        public string Name { get; set; }
        public double Area { get; set; }

        public int CompareTo(object obj)
        {
            ShapeSort PassedShape = (ShapeSort)obj;

            if (this.Area > PassedShape.Area)
                return 1;
            else if (this.Area < PassedShape.Area)
                return -1;
            else
                return 0;
        }
    }
}
