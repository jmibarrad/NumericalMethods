using System;
using Algorithms;
using MathExpressionsNET;

namespace TestLibraries
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var f = new MathFunc("x + sin(x) + ln(x)");
            //var derivative = f.GetDerivative();
		
            //// func == (x ^ 2 * 2 + -1) ^ -2;
            //using (var mathAssembly = new MathAssembly("x^2+x^3+34*x^2","x"))
            //{
            //    var funcResult = mathAssembly.Func(5);
            //    // funcResult == 0.00041649312786339027 (precision value is -1/2401)
            //    var funcDerResult = mathAssembly.FuncDerivative(5);
            //    // funcDerResult == -0.00033999439009256349 (precision value is -40/117649)
            //    Console.WriteLine(funcResult+" "+funcDerResult);

            //}

            var obj = new InterpolacionMedianteTrazadores();
            string function = "";
            double[] x = {-0.5,-.25,0};
            double[] a = {-.02475,.3349375,1.101};
            double Fp0=0.751;
            double Fpn=4.002; 
            obj.Calculate(function,x,a,Fp0,Fpn );
            foreach (var v in obj.StepsLog)
            {
                Console.WriteLine(v);
            }

            var obj2 = new InterpolanteDeNewton();
            double[] x1 = { -2, 0, 1 };
            double[] y = { 0, 1, -1 };
            double value = 1;
            Console.WriteLine(obj2.Calculate(x1, y, value));

            Console.Read();
        }
    }
}
