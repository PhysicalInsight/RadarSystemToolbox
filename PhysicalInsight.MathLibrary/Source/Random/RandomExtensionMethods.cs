using System;

namespace PhysicalInsight.MathLibrary
{
    public static class RandomExtensionMethods
    {
        public static double NextDouble(this Random random, double minValue, double maxValue)
        {
            var sample = random.NextDouble();
            var range = maxValue - minValue;

            var result = sample * range + minValue;

            return result;
        }
    }
}