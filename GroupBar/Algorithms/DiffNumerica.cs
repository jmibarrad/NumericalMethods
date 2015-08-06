namespace Algorithms
{
    public class DiffNumerica
    {
        public string Calculate(double[] x, double[] fx, double XD, int N)
        {
            double DP = 0;
            var i = 0;
            while (i <= N)
            {
                double p = 1;
                var j = 0;
                while (j <= N)
                {
                    if (i != j)
                        p *= (x[i] - x[j]);
                    j++;
                }
                var k = 0;
                double s = 0;
                while (k <= N)
                {
                    if (i != k)
                    {
                        double Pone = 1;
                        j = 0;
                        while (j <= N)
                        {
                            if (j != i && j != k)
                                Pone *= (XD - x[j]);
                            j++;
                        }
                        s += Pone;
                    }
                    k++;
                }
                DP = DP + (fx[i] / p) * s;
                i++;
            }
            return " :" + DP;

        }
    }
}
