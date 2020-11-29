using System;

namespace PhysicalInsight.MathLibrary
{
    public partial class Vector
    {
        public Matrix Transpose()
        {
            var result = new Matrix(1, NumberOfElements);

            for (int j = 0; j < NumberOfElements; j++)
            {
                result[0, j] = this[j];
            }

            return result;
        }

        public Vector Sqrt()
        {
            var result = new Vector(NumberOfElements);

            for (int i = 0; i < NumberOfElements; i++)
            {
                result[i] = Math.Sqrt(Data[i]);
            }

            return result;
        }
    }
}