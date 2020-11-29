using MathNet.Numerics.Distributions;
using System;
using static System.Math;

namespace PhysicalInsight.MathLibrary
{
    public static class RayleighDistribution
    {
        public static double GetSampleFromScaleParameter(Random random, double scaleParameter)
        {
            var sample = Rayleigh.Sample(random, scaleParameter);

            return sample;
        }

        public static double GetSampleFromMean(Random random, double mean)
        {
            var scaleParameter = mean / Sqrt(PI / 2);

            var sample = Rayleigh.Sample(random, scaleParameter);

            return sample;
        }
    }
}