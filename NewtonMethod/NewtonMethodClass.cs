using System;

namespace NewtonMethod
{
    public class NewtonMethodClass
    {
        public static double GetRootByNewtonMethod(int power, double number, double accuracy)
        {
            if (accuracy < 0.0 || accuracy > 1.0)
                throw new Exception("Accurasy should be more then 0 & less then 1.");
            if (power == 0)
                return 1;
            if (number == 0 && power == 0)
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
                double nx = ((((double)power - 1) * x) + (number / Math.Pow(x, ((double)power - 1))))/ (double)power;
                if (Math.Abs(x - nx) < accuracy) break;
                x = nx;
            }
            int round = 0;
            while (accuracy < 1)
            {
                accuracy *= 10;
                round++;
            }
            return Math.Round(x, round);
        }
    }
}
