using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Services
{
    public static class CastInputs
    {
        public static double ToDouble(this string input)
        {
            return double.Parse(input);
        }

        public static Int32 ToInt32(this string input)
        {
            return Int32.Parse(input);
        }

        public static IEnumerable<double> ToDoubleList(this string input)
        {
            return input.Split(',').Select(double.Parse);
        }

        public static double[,] ToDoubleBidimensionalArray(this string input)
        {
            var doubleRows = input.Split(';');
            var doubleColumns = input.Split(';')[0].Split(',').Count();

            for (int i = 0; i<doubleRows.Count(); i++)
            {
                doubleRows[i] = doubleRows[i].Replace('{',' ');
                doubleRows[i] = doubleRows[i].Replace('}', ' ');
            }

            var result = new double[doubleRows.Count(), doubleColumns];

            for (int i = 0; i < doubleRows.Count(); i++)
            {
                var temp = doubleRows[i].Split(',').ToArray();
                for (int j = 0; j < doubleColumns; j++)
                {
                    result[i, j] = double.Parse(temp[j]);
                }
            }

            return result;
        }

        public static double[][] ToDoubleArrayOfArrays(this string input)
        {
            var doubleRows = input.Split(';');
            int doubleColumns = input.Split(';')[0].Split(',').Count();

            for (int i = 0; i < doubleRows.Count(); i++)
            {
                doubleRows[i] = doubleRows[i].Replace('{', ' ');
                doubleRows[i] = doubleRows[i].Replace('}', ' ');
            }

            var result = new double[doubleRows.Count()][];
            
            for (var i = 0; i < doubleRows.Count(); i++)
            {
                var temp = doubleRows[i].Split(',').Select(double.Parse).ToArray();
                for (var j = 0; j < doubleColumns; j++)
                {
                    result[i] = temp;
                }
            }

            return result;
        }
    }
}