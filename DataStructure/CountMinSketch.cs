using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class CountMinSketch
    {
        public double CalculateHeight(double accuracy)
        {
            return Math.Ceiling(2/accuracy);
        }

        public double CalculateWidth(double certanty)
        {
            var numerator = -Math.Log(1 - certanty);
            var denominator = Math.Log(2);
            return Math.Ceiling(numerator/denominator);
        }
    }
}
