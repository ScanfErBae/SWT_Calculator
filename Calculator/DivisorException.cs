using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class DivisorException : Exception
    {
        public double Divisor { get; private set; }

        public DivisorException(double divisor)
        {
            Divisor = divisor;
        }
    }
}
