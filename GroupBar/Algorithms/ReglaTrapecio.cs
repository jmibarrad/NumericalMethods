using Algorithms.Services;

namespace Algorithms
{
    public class ReglaTrapecio : ProcessLog
    {
        public string Calculate(string function, double limiteA, double limiteB, int iteracion)
        {
            var suma = 0.0;
            var dx = (limiteB - limiteA) / iteracion;
            var xi = limiteA;
            var i = 1;
            while (i < iteracion)
            {
                xi = xi + dx;
                suma = suma + (2 * Fn(function, xi));
                FillProcess("#" + (i) + "  Dx= " + dx + "  xi= " + xi + "  Suma= " + suma);
                i++;
            }
            var area = dx / 2 * ((Fn(function, limiteA) + suma + Fn(function, limiteB)));
            return "La Respuesta Correcta es :" + area;
        }
    }
}
