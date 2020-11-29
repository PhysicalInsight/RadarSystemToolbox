using static System.Math;

namespace PhysicalInsight.MathLibrary
{
    public class Polars
    {
        public double Range { get; set; }

        public double RangeRate { get; set; }

        public double AzimuthAngle { get; set; }

        public double AzimuthRate { get; set; }

        public double ElevationAngle { get; set; }

        public double ElevationRate { get; set; }

        public double GroundRange => Range * Cos(ElevationAngle);

        public Polars()
        {
        }

        public Polars(double range, double rangeRate, double azimuthAngle, double azimuthRate, double elevationAngle, double elevationRate)
        {
            Range = range;
            RangeRate = rangeRate;
            AzimuthAngle = azimuthAngle;
            AzimuthRate = azimuthRate;
            ElevationAngle = elevationAngle;
            ElevationRate = elevationRate;
        }

        public Polars(double[] polars)
        {
            Range = polars[0];
            RangeRate = polars[1];
            AzimuthAngle = polars[2];
            AzimuthRate = polars[3];
            ElevationAngle = polars[4];
            ElevationRate = polars[5];
        }

        public Polars(Vector polars) : this(polars.Data)
        {
        }

        public Cartesians ToCartesians()
        {
            var cartesians = CoordinateConversions.PolarsToCartesians(this);

            return cartesians;
        }

        public Matrix JacobianCartesiansWrtPolars()
        {
            var j = CoordinateConversions.JacobianCartesiansWrtPolars(this);

            return j;
        }
    }
}