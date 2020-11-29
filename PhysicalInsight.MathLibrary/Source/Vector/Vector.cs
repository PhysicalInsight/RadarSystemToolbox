using MathNet.Numerics.Distributions;
using System;

namespace PhysicalInsight.MathLibrary
{
    public partial class Vector : IVector<double>
    {
        public int NumberOfElements => Data.Length;

        public double[] Data { get; set; }

        public Vector()
        {
            Data = new double[0];
        }

        public Vector(int numberOfElements)
        {
            Data = new double[numberOfElements];
        }

        public Vector(params double[] data)
        {
            Data = data;
        }

        public double this[int index]
        {
            get => Data[index];
            set => Data[index] = value;
        }

        public static Vector GetNormalDistributionSamples(double mean, double standardDeviation, Random random, int numberOfElements)
        {
            var distribution = Normal.WithMeanStdDev(mean, standardDeviation, random);

            var result = new Vector(numberOfElements);

            distribution.Samples(result.Data);

            return result;
        }

        public static Vector LinearlySpacedVector(double start, double step, int numberOfElements)
        {
            var result = new Vector(numberOfElements);

            var x = start;

            for (int i = 0; i < numberOfElements; i++)
            {
                result.Data[i] = x;
                x += step;
            }

            return result;
        }

        public static double CrossProduct(Vector a, Vector b)
        {
            var result = 0.0;

            for (int i = 0; i < a.NumberOfElements; i++)
            {
                result += a[i] * b[i];
            }

            return result;
        }
    }
}