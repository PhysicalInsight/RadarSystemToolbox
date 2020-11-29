namespace PhysicalInsight.MathLibrary
{
    public partial class Vector
    {
        public static Vector operator +(Vector a, double b)
        {
            var result = new Vector(a.NumberOfElements);

            for (int i = 0; i < result.NumberOfElements; i++)
            {
                result[i] = a[i] + b;
            }

            return result;
        }

        public static Vector operator +(double a, Vector b)
        {
            var result = new Vector(b.NumberOfElements);

            for (int i = 0; i < result.NumberOfElements; i++)
            {
                result[i] = a + b[i];
            }

            return result;
        }

        public static Vector operator +(Vector a, Vector b)
        {
            var result = new Vector(a.NumberOfElements);

            for (int i = 0; i < result.NumberOfElements; i++)
            {
                result[i] = a[i] + b[i];
            }

            return result;
        }

        public static Vector operator -(Vector a)
        {
            var result = new Vector(a.NumberOfElements);

            for (int i = 0; i < result.NumberOfElements; i++)
            {
                result[i] = -a[i];
            }

            return result;
        }

        public static Vector operator -(Vector a, double b)
        {
            var result = new Vector(a.NumberOfElements);

            for (int i = 0; i < result.NumberOfElements; i++)
            {
                result[i] = a[i] - b;
            }

            return result;
        }

        public static Vector operator -(double a, Vector b)
        {
            var result = new Vector(b.NumberOfElements);

            for (int i = 0; i < result.NumberOfElements; i++)
            {
                result[i] = a - b[i];
            }

            return result;
        }

        public static Vector operator -(Vector a, Vector b)
        {
            var result = new Vector(a.NumberOfElements);

            for (int i = 0; i < result.NumberOfElements; i++)
            {
                result[i] = a[i] - b[i];
            }

            return result;
        }

        public static Vector operator *(Vector a, double b)
        {
            var result = new Vector(a.NumberOfElements);

            for (int i = 0; i < result.NumberOfElements; i++)
            {
                result[i] = a[i] * b;
            }

            return result;
        }

        public static Vector operator *(double a, Vector b)
        {
            var result = new Vector(b.NumberOfElements);

            for (int i = 0; i < result.NumberOfElements; i++)
            {
                result[i] = a * b[i];
            }

            return result;
        }

        public static Vector operator *(Vector a, Vector b)
        {
            var result = new Vector(a.NumberOfElements);

            for (int i = 0; i < result.NumberOfElements; i++)
            {
                result[i] = a[i] * b[i];
            }

            return result;
        }

        public static Vector operator /(Vector a, double b)
        {
            var result = new Vector(a.NumberOfElements);

            for (int i = 0; i < result.NumberOfElements; i++)
            {
                result[i] = a[i] / b;
            }

            return result;
        }

        public static Vector operator /(double a, Vector b)
        {
            var result = new Vector(b.NumberOfElements);

            for (int i = 0; i < result.NumberOfElements; i++)
            {
                result[i] = a / b[i];
            }

            return result;
        }

        public static Vector operator /(Vector a, Vector b)
        {
            var result = new Vector(a.NumberOfElements);

            for (int i = 0; i < result.NumberOfElements; i++)
            {
                result[i] = a[i] / b[i];
            }

            return result;
        }
    }
}