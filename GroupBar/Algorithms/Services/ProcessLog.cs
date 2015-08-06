using System.Collections.Generic;
using MathExpressionsNET;

namespace Algorithms.Services
{
    public class ProcessLog
    {
        public List<string> StepsLog = new List<string>();

        public void FillProcess(string step)
        {
            StepsLog.Add(step);
        }

        public double Fn(string function, double x)
        {
            var parser = new MathParser();
            parser.LocalVariables.Add("x", (decimal)x);
            var result = parser.Parse(function);

            return (double)result;
        }

        public double Fn2(string function, double x)
        {
            var mathAssembly = new MathAssembly(function, "x");
            return mathAssembly.Func(x);
        }

        public double Fn2SimpleDerivative(string function, double x)
        {
            var mathAssembly = new MathAssembly(function, "x");
            return mathAssembly.FuncDerivative(x);
        }

        public double Fn2Derivative(string function, double x, int power)
        {
            MathFunc tmpDerivative = null;
            for (int i=0; i<power; i++)
            {
                tmpDerivative = new MathFunc(function).GetDerivative();
            }

            return Fn2(tmpDerivative.ToString(), x);
        }

        public List<double> SwapDoubleValues(double value1, double value2)
        {
            var listSwapValues = new List<double> {value1, value2};
            return listSwapValues;
        }
    }
}
