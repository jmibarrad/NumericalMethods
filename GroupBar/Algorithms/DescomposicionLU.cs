using System;
using System.Globalization;
using Algorithms.Services;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Algorithms
{
    public class DescomposicionLU: ProcessLog
    {
        public void Calculate(double[,] x)
        {
            var m = DenseMatrix.OfArray(x);
            try
            {
                var p = m.LU();
                FillProcess(@"Upper Triangle");
                FillProcess(p.U.ToMatrixString());
                FillProcess(@"Lower Triangle");
                FillProcess((p.L).ToMatrixString());
                FillProcess(@"Permutation matrix");
                var arrLength = int.Parse(Math.Sqrt(x.Length).ToString(CultureInfo.InvariantCulture));
                var array = new double[arrLength, arrLength];

                for (int i = 0; i < arrLength; i++)
                {
                    for (int j = 0; j < arrLength; j++)
                    {
                        if (p.P[i] == j)
                            array[i, j] = 1;
                        else
                            array[i, j] = 0;
                        FillProcess(array[i, j] + " ");
                    }
                    FillProcess("");
                }
            }
            catch (ArgumentException)
            {
                FillProcess("La Matriz No es Cuadrada");
            }
        }
    }
}
