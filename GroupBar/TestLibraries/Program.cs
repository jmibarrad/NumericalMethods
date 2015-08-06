using System;
using Algorithms;
using Algorithms.Services;

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

           /* var obj = new InterpolacionMedianteTrazadores();
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
            */
            string parse = "{1, 5, 7, 10}; { 2, 3, 5, 6}; { 7, 2, 8, 4}; { 4, 7, 10, -13}";
            var obj = new GaussJordan();
            var my = parse.ToDoubleArrayOfArrays();
            double[,] matrix =  { { 1, 1, 1, 3 }, { 2, 3, 7, 0 }, { 1, 3, -2, 17 }};

            var mtri = obj.Calculate(matrix, 3);
            obj.PrintMatrix(mtri, 3);
            double[] vec = { 12, 8, 5, 17 };
            var obj5 = new Gauss();
            obj5.Calculate(my, vec);
            /*Console.WriteLine();

            my.MatrixGauss(vec);*/

            Console.ReadKey();
        }

    }

    public static class MyExtensions
    {
        public static double[][] MatrixGauss(this double[][] matrix, double[] vector)
        {
            int dimension = matrix.Length;
            double[] b = vector;
            double[][] result = matrix;
            double[][] tmpMatrix = CreateIdentityMatrix(dimension);
            for (int i = 0; i < dimension - 1; i++)
            {
                for (int j = i + 1; j < dimension; j++)
                {
                    tmpMatrix[j][i] = -result[j][i] / result[i][i];
                }
                
                result = tmpMatrix.MatrixProduct(result);
                b = tmpMatrix.MatrixProduct(b);
                tmpMatrix = CreateIdentityMatrix(dimension);
            }

            var vec = new double[dimension];
            vec[dimension - 1] = b[dimension - 1] / result[dimension - 1][dimension - 1];
            for (int i = vec.Length - 2; i >= 0; i--)
            {
                var dod = b[i];
                for (int j = dimension - 1; j > i; j--)
                {
                    dod -= result[i][j] * vec[j];
                }

                vec[i] = dod / result[i][i];
            }

            PrintSolvedMatrix(result, b);

            return result;
        }

        public static double[] MatrixProduct(this double[][] matrixA, double[] vectorB)
        {
            int aRows = matrixA.Length; int aCols = matrixA[0].Length;
            int bRows = vectorB.Length;
            if (aCols != bRows)
                throw new Exception("NOT SQUARE MATRIX");
            double[] result = new double[aRows];
            for (int i = 0; i < aRows; ++i) 
                for (int k = 0; k < aCols; ++k)
                    result[i] += matrixA[i][k] * vectorB[k];
            return result;
        }

        public static double[][] MatrixProduct(this double[][] matrixA, double[][] matrixB)
        {
            int aRows = matrixA.Length; int aCols = matrixA[0].Length;
            int bRows = matrixB.Length; int bCols = matrixB[0].Length;
            if (aCols != bRows)
                throw new Exception("NOT SQUARE MATRIX");
            double[][] result = ZerosMatrixCreate(aRows, bCols);
            for (int i = 0; i < aRows; ++i) // each row of A
                for (int j = 0; j < bCols; ++j) // each col of B
                    for (int k = 0; k < aCols; ++k)
                        result[i][j] += matrixA[i][k] * matrixB[k][j];
            return result;
        }

        public static double[][] ZerosMatrixCreate(int rows, int cols)
        {
            var result = new double[rows][];
            for (int i = 0; i < rows; ++i)
                result[i] = new double[cols];
            return result;
        }

        public static string MatrixAsString(this double[][] matrix, double[] vector)
        {
            string s = "";
            for (int i = 0; i < matrix.Length; ++i)
            {
                for (int j = 0; j < matrix[i].Length; ++j)
                    s += matrix[i][j].ToString("F3").PadLeft(8) + " ";
                s += vector[i].ToString("F3").PadLeft(8) + " ";
                s += Environment.NewLine;
            }
            return s;
        }

        public static double[][] CreateIdentityMatrix(int dimension)
        {
            var result = new double[dimension][];
            for (int i = 0; i < dimension; ++i)
            {
                result[i] = new double[dimension];
                result[i][i] = 1.0;
            }

            return result;
        }
        public static void PrintSolvedMatrix(double[][] matrix, double[] vector)
        {

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (i == j && matrix[i][j] != 1)
                    {
                        var coeficient = matrix[i][j];
                        vector[i] /= coeficient;
                        for (int k = 0; k < matrix[i].Length; k++)
                        {
                            matrix[i][k] /= coeficient;
                        }
                    }

                }
            }

            Console.Write(matrix.MatrixAsString(vector));
        }
    }
}
