using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CalcActions
    {
        // Step 1
        public delegate double ActionDelegate(double a, double b);
        // Step2
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtr(double a, double b)
        {
            return a - b;
        }
    }
}
