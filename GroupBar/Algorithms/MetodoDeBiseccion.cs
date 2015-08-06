using Algorithms.Services;

namespace Algorithms
{
    public class MetodoDeBiseccion: ProcessLog
    {
        
        public string Calculate(string function, double a, double b, double tol, int iterator)
        {

            if ((Fn(function, a) < 0 && Fn(function, b) < 0) || (Fn(function, b) > 0 && Fn(function, a) > 0) || a > b)
                return "El método fracasó.";
            var FA = Fn(function, a);
            var i = 1;
            while (i <= iterator)
            {
                double processPartialResult = a + ((b - a) / 2);
                var FP = Fn(function, processPartialResult);
                FillProcess("#" + (i) + "  A= " + a + "  B= " + b + "  P= " + processPartialResult + "  F(p)= " + FP);
                
                if (FP == 0 || (b - a) / 2 < tol)
                    return "Proceso: #" + (i) + " = " + processPartialResult;
                i++;
                if (FA * FP > 0)
                {
                    a = processPartialResult;
                    FA = FP;
                }
                else
                    b = processPartialResult;
            }
            return "El metodo fracaso despues de " + iterator + " iteraciones";
        }
    }
}
