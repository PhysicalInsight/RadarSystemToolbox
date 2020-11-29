namespace PhysicalInsight.MathLibrary
{
    public interface IInterpolation
    {
        double[] X { get; set; }

        double[] Y { get; set; }

        double Interpolate(double x);
    }
}