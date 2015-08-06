using System;

namespace Algorithms
{
    public class Gauss
    {

        public void Calculate(double[][] matrix, double[] vector)
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

                result = MatrixProduct(tmpMatrix,result);
                b = MatrixProduct(tmpMatrix,b);
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
        }

        #region enchant Algorithm
        void EvaluateSwapRows(double [][] matrix, double[] vector)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if(i == j && matrix[i][j] != 1)
                        Console.Write("");
                }
            }
        }

        int SearchOneRow(double[][] matrix, int i, int j)
        {
            //for()
            return 0;
        }
        #endregion

        public static double[] MatrixProduct(double[][] matrixA, double[] vectorB)
        {
            var aRows = matrixA.Length; 
            var aCols = matrixA[0].Length;
            var bRows = vectorB.Length;

            if (aCols != bRows)
                throw new Exception("NOT SQUARE MATRIX");

            var result = new double[aRows];

            for (int i = 0; i < aRows; ++i)
                for (int k = 0; k < aCols; ++k)
                    result[i] += matrixA[i][k] * vectorB[k];

            return result;
        }

        public static double[][] MatrixProduct(double[][] matrixA, double[][] matrixB)
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

        public static string MatrixAsString(double[][] matrix, double[] vector)
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

            Console.Write(MatrixAsString(matrix,vector));
        }
    }
}
