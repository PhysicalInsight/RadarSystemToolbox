using System.Collections;
using System.Numerics;

namespace PhysicalInsight.MathLibrary
{
    public class ComplexVector : IVector<Complex>, IEnumerable
    {
        public int NumberOfElements => Data.Length;

        public Complex[] Data { get; set; }

        public ComplexVector()
        {
            Data = new Complex[0];
        }

        public ComplexVector(int numberOfElements)
        {
            Data = new Complex[numberOfElements];
        }

        public ComplexVector(Complex[] data)
        {
            Data = data;
        }

        public ComplexVector(Vector I, Vector Q) : this(I.Data, Q.Data)
        {
        }

        public ComplexVector(double[] I, double[] Q)
        {
            var numberOfElements = I.Length;

            Data = new Complex[numberOfElements];

            for (int i = 0; i < numberOfElements; i++)
            {
                Data[i] = new Complex(I[i], Q[i]);
            }
        }

        public Complex this[int index]
        {
            get => Data[index];
            set => Data[index] = value;
        }

        public Vector Real
        {
            get
            {
                var result = new Vector(NumberOfElements);

                for (int i = 0; i < NumberOfElements; i++)
                {
                    result.Data[i] = Data[i].Real;
                }

                return result;
            }
        }

        public Vector Imaginary
        {
            get
            {
                var result = new Vector(NumberOfElements);

                for (int i = 0; i < NumberOfElements; i++)
                {
                    result.Data[i] = Data[i].Imaginary;
                }

                return result;
            }
        }

        public Vector Magnitude
        {
            get
            {
                var result = new Vector(NumberOfElements);

                for (int i = 0; i < NumberOfElements; i++)
                {
                    result.Data[i] = Data[i].Magnitude;
                }

                return result;
            }
        }

        public Vector Phase
        {
            get
            {
                var result = new Vector(NumberOfElements);

                for (int i = 0; i < NumberOfElements; i++)
                {
                    result.Data[i] = Data[i].Phase;
                }

                return result;
            }
        }

        public static ComplexVector operator +(ComplexVector x, ComplexVector y)
        {
            var result = new ComplexVector(x.NumberOfElements);

            for (int i = 0; i < x.NumberOfElements; i++)
            {
                result.Data[i] = x.Data[i] + y.Data[i];
            }

            return result;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Data.GetEnumerator();
        }
    }
}