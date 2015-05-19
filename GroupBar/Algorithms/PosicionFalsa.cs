using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Services;

namespace Algorithms
{
    public class PosicionFalsa: ProcessLog
    {
        public string Calculate(string function, double p0, double p1, double tol, int iterador)
        {
            var q0 = Fn(function, p0);
            var q1 = Fn(function, p1);
            var i = 2;
            for ( ; i <= iterador; i++)
            {
                var processPartialResult = p1 - (q1 * (p1 - p0) / (q1 - q0));
                FillProcess("p = " + processPartialResult);
                if (Math.Abs(processPartialResult - p1) < tol)
                {
                    return "= " + processPartialResult;
                }

                var qProcessPartialResult = Fn(function,processPartialResult);

                if ((qProcessPartialResult*q1) < 0)
                {
                    p0 = p1;
                    q0 = q1;
                }

                p1 = processPartialResult;
                q1 = qProcessPartialResult;


            }
            return "Processo falló en la iteración: " + i;
        }
    }
}
