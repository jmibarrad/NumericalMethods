using System;
using Algorithms.Services;

namespace Algorithms
{
    public  class PuntoFijo : ProcessLog
    {

       public string Calculate(string function, string function2, double aprox, double tol, double iterator)
       {
           for (var i=1 ; i <= iterator ; i++)
           {
               var p = Fn(function2, aprox);
               FillProcess("#" + (i) + "  p0= " + aprox + "  P= " + p);
               if (Math.Abs(p - aprox) < tol)
                 return "#Paso: "+(i)+" = "+p;
              
               aprox = p;
           }

           return "El metodo fracaso despues de " + iterator + " iteraciones";
       }
    }
}