using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Calculation
{
    internal class Adams
    {
        public static Dictionary<double, double> Calculate(InputEquation equation, Tuple<double, double> interval, double x0, double y0, double h, double epsilon)
        {
            var result = new Dictionary<double, double>();
            var c = equation.C(x0, y0);
            for(int i = 0; i < 4; i++)
                result.Add(x0 + i * h, equation.Answer(x0 + i * h, c));
            var x = x0 + 4 * h;
            for (int i = 4; x < interval.Item2 && i <= 1 / h; i++)
            {
                x = x0 + i * h;
                var i3 = equation.Function(result.ElementAt(i - 4).Key, result.ElementAt(i - 4).Value);
                var i2 = equation.Function(result.ElementAt(i - 3).Key, result.ElementAt(i - 3).Value);
                var i1 = equation.Function(result.ElementAt(i - 2).Key, result.ElementAt(i - 2).Value);
                var i0 = equation.Function(result.ElementAt(i - 1).Key, result.ElementAt(i - 1).Value);
                var df1 = i0 - i1;
                var df2 = i0 - 2 * i1 + i2;
                var df3 = i0 - 3 * i1 + 3 * i2 - i3;
                var y = result.ElementAt(i - 1).Value + h * i0 + (h * h / 2) * df1 + (5 * h * h * h / 12) * df2 + (3 * h * h * h * h / 8) * df3;
                var error = Math.Abs(equation.Answer(x, c) - y);
                if (error > epsilon)
                {
                    h /= 2;
                    return Calculate(equation, interval, x0, y0, h, epsilon);
                }
                result.Add(x, y);
            }

            return result;
        }
    }
}
