using System;
using Algorithms.Services;

namespace Algorithms
{
    public class GaussJordan : ProcessLog
    {
        public double[,] Calculate(double[,] matrix, int dimension)
        {

            for (var i = 0; i < dimension; i++)
            {
                var temp = matrix[i, i];

                for (var j = 0; j < dimension + 1; j++)
                {
                    matrix[i, j] = matrix[i, j] / temp;
                }

                for (var k = 0; k < dimension; k++)
                {
                    temp = matrix[k, i];
                    if (i != k)
                    {
                        for (var j = 0; j <= dimension; j++)
                        {
                            matrix[k, j] = matrix[k, j] - (temp * matrix[i, j]);
                        }
                    }
                }

            }
                 FillProcess("\n");
                FillProcess("Matrix");
                for (int i = 0; i < dimension; i++)
                {
                    for (int j = 0; j <= dimension ; j++)
                    {
                        FillProcess(matrix[i, j].ToString()+"  ");
                    }
                    FillProcess("\n");
                }
        
            return matrix;
        }

        public void PrintMatrix(double[,] matrix, int dimension)
        { }
            
    }
}
