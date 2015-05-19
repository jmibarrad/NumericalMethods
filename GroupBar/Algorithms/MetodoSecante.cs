using System;
using Algorithms.Services;

namespace Algorithms
{
    public class MetodoSecante: ProcessLog
    {

        public string Calculate(string function, double p0, double p1, double tol, int iterator)
        {
            var q0 = Fn(function, p0);
            var q1 = Fn(function, p1);
            var i = 2;
            for ( ; i <= iterator; i++)
            {
                var processPartialResult = p1-(q1*(p1-p0)/(q1-q0));
                FillProcess("p = "+processPartialResult);
                if (Math.Abs(processPartialResult - p1) < tol)
                {
                    return "= "+processPartialResult;
                }

                p0 = p1;
                q0 = q1;
                p1 = processPartialResult;
                q1 = Fn(function, processPartialResult);

            }
            return "Processo falló en la iteración: " + i;
        }
    }
}
