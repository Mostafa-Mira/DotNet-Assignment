using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_08
{
    internal class SquareSeries : IShapeSeries
    {
        public int CurrentShapeArea { get; set; }

        int Side = 0;

        public void GetNextArea()
        {
            Side++;
            CurrentShapeArea = Side * Side;
        }

        public void ResetSeries()
        {
            Side = 0;
            CurrentShapeArea = 0;
        }
    }
}
