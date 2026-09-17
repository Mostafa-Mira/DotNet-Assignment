using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_08
{
    internal class ConsoleLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Console Log");
        }
    }
}
