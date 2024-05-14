using System;

namespace Lab2.Calculation
{
    internal class InputEquation
    {
        Func<double, double, double> function;
        Func<double, double, double> answer;
        Func<double, double, double> c;

        string label;
        string answerLatex;

        public InputEquation(Func<double, double, double> function, Func<double, double, double> answer, Func<double, double, double> c, string label, string answerLatex)
        {
            this.function = function;
            this.answer = answer;
            this.c = c;
            this.label = label;
            this.answerLatex = answerLatex;
        }

        public Func<double, double, double> Function { get => function; set => function = value; }
        public Func<double, double, double> Answer { get => answer; set => answer = value; }
        public Func<double, double, double> C { get => c; set => c = value; }
        public string Label { get => label; set => label = value; }
        public string AnswerLatex { get => answerLatex; set => answerLatex = value; }

        public override string ToString()
        {
            return label;
        }
    }
}
