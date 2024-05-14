using Lab2.Calculation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Lab2.UI
{
    public partial class InputForm : Form
    {
        InputEquation[] equations = new InputEquation[]{
            new InputEquation((x, y) => y+(1+x)*y*y,
                   (x, c) => -Math.Pow(Math.E, x) / (c + Math.Pow(Math.E, x) * x),
                   (x, y) => (-Math.Pow(Math.E, x) / y) - Math.Pow(Math.E, x) * x,
                   "y+(1+x)y^2",
                   "y=\\\\frac{-e^{x}}{{C}+e^{x}x}"),
            new InputEquation((x, y) => x*y+y,
                   (x, c) => c*Math.Pow(Math.E,(0.5d)*x*(x+2d)),
                   (x, y) => y/Math.Pow(Math.E,(0.5d)*x*(x+2d)),
                   "xy+y",
                   "y={C}e^{\\\\frac{1}{2}x\\\\left(x+2\\\\right)}"),
            new InputEquation((x, y) => 3*y+y*x*x,
                   (x, c) => c*Math.Pow(Math.E,(0.3333333333333d)*x*(x*x+9d)),
                   (x, y) => y/Math.Pow(Math.E,(0.3333333333333d)*x*(x*x+9d)),
                   "3y+yx^2",
                   "y={C}e^{\\\\frac{1}{3}x\\\\left(x^{2}+9\\\\right)}"),
        };

        public InputForm()
        {
            InitializeComponent();
        }

        private async void InputForm_Load(object sender, EventArgs e)
        {
            BackColor = Color.White;
            MinimumSize = Size;
            MaximumSize = Size;
            MaximizeBox = false;
            await graph.EnsureCoreWebView2Async();
            string indexPath = System.IO.Path.Combine(Application.StartupPath, "UI", "Desmos", "index.html");
            graph.Source = new Uri(indexPath);
            methodBox.SelectedIndex = 0;
            functionBox.DataSource = equations;
            functionBox.SelectedIndex = 0;

            //Dictionary<double, double> result = Euler.Calculate(equation, new Tuple<double, double>(1d, 1.5d), 1, -1, 0.1, 0.01);
            //Dictionary<double, double> result2 = Euler.CalculateModified(equation, new Tuple<double, double>(1d, 1.5d), 1, -1, 0.1, 0.01);
            //Dictionary<double, double> result3 = Adams.Calculate(equation, new Tuple<double, double>(1d, 1.5d), 1, -1, 0.1, 0.01);
        }

        private void inputGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            RerenderButton();
        }

        private void RerenderButton()
        {
            calculateButton.Enabled = CheckCalculability();
        }
        private bool CheckCalculability()
        {
            // TODO
            return true;
        }

        private async void calculateButton_Click(object sender, EventArgs e)
        {
            if (!IsDoubleValid(intervalStartBox.Text) || !IsDoubleValid(intervalEndBox.Text))
            {
                MessageBox.Show($"Введен неверный интервал");
                return;
            }
            double intervalStart = ParseDouble(intervalStartBox.Text);
            double intervalEnd = ParseDouble(intervalEndBox.Text);
            if (intervalStart >= intervalEnd)
            {
                MessageBox.Show($"Начало интервало должно быть до его конца");
                return;
            }
            if(!IsDoubleValid(stepBox.Text) || ParseDouble(stepBox.Text) <= 0)
            {
                MessageBox.Show($"Введен неверный шаг");
                return;
            }
            double step = ParseDouble(stepBox.Text);
            if (!IsDoubleValid(epsilonBox.Text) || ParseDouble(epsilonBox.Text) <= 0)
            {
                MessageBox.Show($"Введена неверная точность");
                return;
            }
            double epsilon = ParseDouble(epsilonBox.Text);
            if (!IsDoubleValid(targetXBox.Text) || !IsDoubleValid(targetYBox.Text))
            {
                MessageBox.Show($"Введено неверное начальное значение");
                return;
            }
            double targetX = ParseDouble(targetXBox.Text);
            double targetY = ParseDouble(targetYBox.Text);
            Tuple<double, double> interval = Tuple.Create(intervalStart, intervalEnd);
            Dictionary<double, double> result;
            await graph.CoreWebView2.ExecuteScriptAsync($"clear()");
            InputEquation equation = (InputEquation)functionBox.SelectedItem;
            string c = equation.C(targetX, targetY).ToString().Replace(",", ".");
            if (methodBox.SelectedIndex == 0)
                result = Euler.Calculate(equation, interval, targetX, targetY, step, epsilon);
            else if(methodBox.SelectedIndex == 1)
                result = Euler.CalculateModified(equation, interval, targetX, targetY, step, epsilon);
            else
                result = Adams.Calculate(equation, interval, targetX, targetY, step, epsilon);
            await graph.CoreWebView2.ExecuteScriptAsync($"expression('{equation.AnswerLatex.Replace("{C}", $"({c})")}', 0)");
            int i = 0;
            foreach (double x in result.Keys)
            {
                i++;
                await graph.CoreWebView2.ExecuteScriptAsync($"expression('A_{{{i}}}=({x.ToString().Replace(',', '.')}, {result[x].ToString().Replace(',', '.')})', 'd{i}')");
            }
        }
        public bool IsDoubleValid(string text)
        {
            return double.TryParse(text.Replace(".", ","), out double result);
        }
        private double ParseDouble(string text)
        {
            return double.Parse(text.Replace(".", ","));
        }
        public static string FormatNumber(double number)
        {
            if (number.ToString().Contains("E"))
            {
                string[] parts = number.ToString().Split('E');
                double coefficient = double.Parse(parts[0]);
                int exponent = int.Parse(parts[1]);

                return $"{coefficient} · 10^({exponent})";
            }

            return number.ToString();
        }

        private void targetXBox_TextChanged(object sender, EventArgs e)
        {
            intervalStartBox.Text = targetXBox.Text;
        }
    }
}
