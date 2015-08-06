using Algorithms.Services;

namespace Algorithms
{
    public class Simpson: ProcessLog
    {
       public string Calculate(string function, double a, double b, int N)
       {
           var h = (b - a) / N;
           var x0 = Fn(function, a) + Fn(function, b);
           var x1 = 0.0;
           var x2 = 0.0;
           var x = 0.0;
           for (int i = 1; i <= N - 1; i++)
           {
               x = a + (i * h);
               if ((i % 2) == 0)
                   x2 = x2 + Fn(function, x);
               else
                   x1 = x1 + Fn(function, x);

           }

           var result = h * (x0 + (2 * x2) + (4 * x1)) / 3;
           return "La Respuesta Correcta es :" + result;
       }
    }
}
