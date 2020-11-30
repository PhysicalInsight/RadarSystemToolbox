namespace PhysicalInsight.MathLibrary
{
    public interface IInterpolation
    {
        double[] X { get; init; }

        double[] Y { get; init; }

        double Interpolate(double x);
    }
}