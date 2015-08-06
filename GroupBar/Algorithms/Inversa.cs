using Algorithms.Services;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Algorithms
{
    public class Inversa: ProcessLog
    {
        public void Calculate(double[,] x, double[] b)
        {
            var m = DenseMatrix.OfArray(x);
            var inv = m.Inverse();
            var v = DenseVector.OfArray(b);
            var resp = inv * v;
            FillProcess(@"Matriz Inversa A^-1");
            FillProcess(inv.ToMatrixString());
            FillProcess(@"Vector B");
            FillProcess(v.ToVectorString());
            FillProcess(@"X=A^-1 * B : ");
            FillProcess(resp.ToVectorString());
        }
    }
}
