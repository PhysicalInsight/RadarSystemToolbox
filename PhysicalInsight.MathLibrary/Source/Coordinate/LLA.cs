namespace PhysicalInsight.MathLibrary
{
    public class LLA
    {
        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public double Altitude { get; set; }

        public double LatitudeDeg { get => Latitude.ToDegrees(); set => Latitude = value.FromDegrees(); }

        public double LongitudeDeg { get => Longitude.ToDegrees(); set => Longitude = value.FromDegrees(); }

        public LLA()
        {
        }

        public LLA(double latitude, double longitude, double altitude)
        {
            Latitude = latitude;
            Longitude = longitude;
            Altitude = altitude;
        }

        public LLA(double[] lla)
        {
            Latitude = lla[0];
            Longitude = lla[1];
            Altitude = lla[2];
        }

        public LLA(Vector lla) : this(lla.Data)
        {
        }

        public XYZ ToXYZ(LLA positionOrigin)
        {
            var xyz = LLAConversions.ConvertLLAToXYZ(this, positionOrigin);
            return xyz;
        }
    }
}