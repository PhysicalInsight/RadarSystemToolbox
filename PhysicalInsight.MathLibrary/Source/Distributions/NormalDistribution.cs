using MathNet.Numerics.Distributions;
using System;

namespace PhysicalInsight.MathLibrary
{
    public static class NormalDistribution
    {
        public static double GetSample(Random random, double mean, double standardDeviation)
        {
            var result = Normal.Sample(random, mean, standardDeviation);

            return result;
        }
    }
}