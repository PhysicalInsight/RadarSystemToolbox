namespace PhysicalInsight.MathLibrary
{
    public class RAE
    {
        public double R { get; set; }

        public double A { get; set; }

        public double E { get; set; }

        public RAE()
        {
        }

        public RAE(double a, double e)
        {
            R = 1.0;
            A = a;
            E = e;
        }

        public RAE(double r, double a, double e)
        {
            R = r;
            A = a;
            E = e;
        }

        public RAE(double[] rae)
        {
            R = rae[0];
            A = rae[1];
            E = rae[2];
        }

        public RAE(Vector rae) : this(rae.Data)
        {
        }

        public double Magnitude()
        {
            return R;
        }

        public RAE UnitVector()
        {
            var unitVector = new RAE()
            {
                R = 1.0,
                A = A,
                E = E
            };

            return unitVector;
        }

        public XYZ ToXYZ()
        {
            var xyz = CoordinateConversions.RAEToXYZ(this);

            return xyz;
        }
    }
}