using System;
using Algorithms.Services;

namespace Algorithms
{
    public class MetodoNewton: ProcessLog
    {
        public string Calculate(string function, double aprox, double tol, int iterador)
        {
            int i = 1;
            while (i <= iterador)
            {
                double p = aprox - (Fn2(function, aprox)/Fn2SimpleDerivative("(2*x)-5", aprox));
                FillProcess("#" + (i) + "  Po= " + aprox + "  P= " + p);
                if (Math.Abs(p - aprox) < tol)
                    return "P" + (i) + "= " + p;
                i++;
                aprox = p;
            }
            return "El metodo fracaso despues de " + iterador + " iteraciones";
        }

    }
}
