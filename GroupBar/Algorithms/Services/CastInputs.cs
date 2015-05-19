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
            return input.Split('&').Select(double.Parse);
        } 
    }
}