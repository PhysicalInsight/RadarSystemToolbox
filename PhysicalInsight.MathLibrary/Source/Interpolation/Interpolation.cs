namespace PhysicalInsight.MathLibrary
{
    public class Interpolation : IInterpolation
    {
        public double[] X { get; init; }

        public double[] Y { get; init; }

        private MathNet.Numerics.Interpolation.IInterpolation Interpolant { get; set; }

        public Interpolation(double[] x, double[] y)
        {
            X = x;
            Y = y;

            Interpolant = MathNet.Numerics.Interpolate.Linear(x, y);
        }

        public double Interpolate(double x)
        {
            var result = Interpolant.Interpolate(x);

            return result;
        }
    }
}