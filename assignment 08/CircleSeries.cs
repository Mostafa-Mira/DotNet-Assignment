using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_08
{
    internal class CircleSeries : IShapeSeries
    {
        public int CurrentShapeArea { get; set; }

        int Radius = 0;

        public void GetNextArea()
        {
            Radius++;
            CurrentShapeArea = (int)(Math.PI * Radius * Radius);
        }

        public void ResetSeries()
        {
            Radius = 0;
            CurrentShapeArea = 0;
        }
    }
}
