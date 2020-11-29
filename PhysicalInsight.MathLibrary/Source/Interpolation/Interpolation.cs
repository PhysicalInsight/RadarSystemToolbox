namespace PhysicalInsight.MathLibrary
{
    public class Interpolation : IInterpolation
    {
        public double[] X { get; set; }

        public double[] Y { get; set; }

        private MathNet.Numerics.Interpolation.IInterpolation Interpolant;

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