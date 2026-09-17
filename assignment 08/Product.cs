using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_08
{
    internal class Product : IComparable
    {
        public int Id;
        public string Name;
        public double Price;

        public int CompareTo(object obj)
        {
            Product product = (Product)obj;

            if (Price > product.Price)
                return 1;
            else if (Price < product.Price)
                return -1;
            else
                return 0;
        }
    }
}
