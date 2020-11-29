using static System.Math;

namespace PhysicalInsight.MathLibrary
{
    public class NED
    {
        public double N { get; set; }

        public double E { get; set; }

        public double D { get; set; }

        public NED()
        {
        }

        public NED(double n, double e, double d)
        {
            N = n;
            E = E;
            D = D;
        }

        public NED(double[] ned)
        {
            N = ned[0];
            E = ned[1];
            D = ned[2];
        }

        public NED(Vector ned) : this(ned.Data)
        {
        }

        public double Magnitude()
        {
            var magnitudeSquared = (N * N + E * E + D * D);

            var magnitude = Sqrt(magnitudeSquared);

            return magnitude;
        }

        public NED UnitVector()
        {
            var magnitude = Magnitude();

            var unitVector = new NED()
            {
                N = N / magnitude,
                E = E / magnitude,
                D = D / magnitude
            };

            return unitVector;
        }

        public RAE ToRAE()
        {
            var rae = CoordinateConversions.NEDToRAE(this);

            return rae;
        }
    }
}