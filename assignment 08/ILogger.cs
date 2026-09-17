using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_08
{
    internal interface ILogger
    {
        void Log()
        {
            Console.WriteLine("Default Log");
        }
    }
}
