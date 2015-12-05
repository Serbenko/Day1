using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonMethod
{
    public class NewtonMethodClass
    {
        public static double GetRootByNewtonMethod(double power, double number, double accuracy)
        {
            if (power == 0)
                return 1;
            if (number == 0 && power > 0)
                return 0;
            if (number == 0 && power < 0)
                return Double.PositiveInfinity;
            if (number < 0 && (power % 2) == 0)
                return Double.NaN;
            if (power < 0)
            {
                power *= -1;
                number = 1 / number;
            }
            double x = 1;
            while(true)
            {
                double nx = (((power - 1) * x) + (number / Math.Pow(x, (power - 1))))/power;
                if (Math.Abs(x - nx) < accuracy) break;
                x = nx;
            }
            return x;
        }
    }
}
