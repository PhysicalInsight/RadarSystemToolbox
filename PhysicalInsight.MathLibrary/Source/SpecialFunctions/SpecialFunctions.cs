namespace PhysicalInsight.MathLibrary
{
    public static class SpecialFunctions
    {
        public static double Erf(double x)
        {
            var y = MathNet.Numerics.SpecialFunctions.Erf(x);

            return y;
        }

        public static double ErfInv(double x)
        {
            var y = MathNet.Numerics.SpecialFunctions.ErfInv(x);

            return y;
        }

        public static double Erfc(double x)
        {
            var y = MathNet.Numerics.SpecialFunctions.Erfc(x);

            return y;
        }

        public static double ErfcInv(double x)
        {
            var y = MathNet.Numerics.SpecialFunctions.ErfcInv(x);

            return y;
        }

        public static double GammaInc(double x, double a)
        {
            var result = MathNet.Numerics.SpecialFunctions.GammaLowerRegularized(a, x);

            return result;
        }

        public static double GammaIncInv(double y, double a)
        {
            var result = MathNet.Numerics.SpecialFunctions.GammaLowerRegularizedInv(a, y);

            return result;
        }
    }
}