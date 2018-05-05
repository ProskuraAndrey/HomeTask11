using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorForms
{
   public  class MathCalculate
    {
        public double Sum(string x,string y)
        {
            double a = Convert.ToDouble(x);
            double b = Convert.ToDouble(y);

            return a + b;
        }

        public double Mul(string x, string y)
        {
            double a = Convert.ToDouble(x);
            double b = Convert.ToDouble(y);

            return a * b;
        }

        public double Sub(string x, string y)
        {
            double a = Convert.ToDouble(x);
            double b = Convert.ToDouble(y);

            return a - b;
        }

        public double Div(string x, string y)
        {
            double a = Convert.ToDouble(x);
            double b = Convert.ToDouble(y);

            return a / b;
        }
    }
}
