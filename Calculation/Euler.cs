using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Calculation
{
    internal class Euler
    {
        public static Dictionary<double, double> Calculate(InputEquation equation, Tuple<double, double> interval, double x0, double y0, double h, double epsilon)
        {
            var result = new Dictionary<double, double>{{ x0, y0 }};
            var x = x0;
            var y = y0;
            for (var i = 1; x <= interval.Item2 && i <= 1 / h; i++)
            {
                var y_next = y + h * equation.Function(x, y);
                var x_next = x + h;
                var y_half_step = y + (h / 2) * equation.Function(x, y);
                y_half_step = y_half_step + (h / 2) * equation.Function(x + h / 2, y_half_step);
                var r = Math.Abs(y_next - y_half_step) / (Math.Pow(2, 2) - 1);
                if (r > epsilon)
                {
                    while(r > epsilon)
                    {
                        h /= 2;
                        y_next = y + h * equation.Function(x, y);
                        y_half_step = y + (h / 2) * equation.Function(x, y);
                        y_half_step = y_half_step + (h / 2) * equation.Function(x + h / 2, y_half_step);
                        r = Math.Abs(y_next - y_half_step) / (Math.Pow(2, 2) - 1);
                    }
                }
                y = y_next;
                x = x_next;
                result.Add(x, y);
            }

            return result;
        }

        public static Dictionary<double, double> CalculateModified(InputEquation equation, Tuple<double, double> interval, double x0, double y0, double h, double epsilon)
        {
            var result = new Dictionary<double, double>{{ x0, y0 }};
            var x = x0;
            var y = y0;
            for (var i = 1; x <= interval.Item2 && i <= 1 / h; i++)
            {
                var y_pred = y + h * equation.Function(x, y);
                var x_next = x + h;
                var y_next = y + h / 2 * (equation.Function(x, y) + equation.Function(x_next, y_pred));
                var y_half_step_pred = y + (h / 2) * equation.Function(x, y);
                var y_half_step = y + h / 4 * (equation.Function(x, y) + equation.Function(x + h / 2, y_half_step_pred));
                y_half_step_pred = y_half_step + (h / 2) * equation.Function(x + h / 2, y_half_step);
                y_half_step = y_half_step + h / 4 * (equation.Function(x + h / 2, y_half_step) + equation.Function(x_next, y_half_step_pred));
                var r = Math.Abs(y_next - y_half_step) / (Math.Pow(2, 2) - 1);
                if (r > epsilon)
                {
                    while (r > epsilon)
                    {
                        h /= 2;
                        y_pred = y + h * equation.Function(x, y);
                        y_next = y + h / 2 * (equation.Function(x, y) + equation.Function(x_next, y_pred));
                        y_half_step_pred = y + (h / 2) * equation.Function(x, y);
                        y_half_step = y + h / 4 * (equation.Function(x, y) + equation.Function(x + h / 2, y_half_step_pred));
                        y_half_step_pred = y_half_step + (h / 2) * equation.Function(x + h / 2, y_half_step);
                        y_half_step = y_half_step + h / 4 * (equation.Function(x + h / 2, y_half_step) + equation.Function(x_next, y_half_step_pred));
                        r = Math.Abs(y_next - y_half_step) / (Math.Pow(2, 2) - 1);
                    }
                }
                y = y_next;
                x = x_next;
                if(!result.ContainsKey(x))
                    result.Add(x, y);
            }

            return result;
        }
    }
}
