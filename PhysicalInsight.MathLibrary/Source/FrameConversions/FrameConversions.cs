using static System.Math;

namespace PhysicalInsight.MathLibrary
{
    public static class FrameConversions
    {
        public static Matrix CalculateTransformationMatrix(double headingAngle, double pitchAngle, double bankAngle)
        {
            var t1 = CalculateHeadingTransformationMatrix(headingAngle);
            var t2 = CalculatePitchTransformationMatrix(pitchAngle);
            var t3 = CalculateBankTransformationMatrix(bankAngle);

            var t = t3 * t2 * t1;

            return t;
        }

        public static Matrix CalculateHeadingTransformationMatrix(double headingAngle)
        {
            var ct = Cos(headingAngle);
            var st = Sin(headingAngle);

            var t = new Matrix(new[,] { { ct, st, 0 }, { -st, ct, 0 }, { 0, 0, 1 } });

            return t;
        }

        public static Matrix CalculatePitchTransformationMatrix(double pitchAngle)
        {
            var ct = Cos(pitchAngle);
            var st = Sin(pitchAngle);

            var t = new Matrix(new[,] { { ct, 0, -st }, { 0, 1, 0 }, { st, 0, ct } });

            return t;
        }

        public static Matrix CalculateBankTransformationMatrix(double bankAngle)
        {
            var ct = Cos(bankAngle);
            var st = Sin(bankAngle);

            var t = new Matrix(new[,] { { 1, 0, 0 }, { 0, ct, st }, { 0, -st, ct } });

            return t;
        }

        public static (double accelerationNorth, double accelerationEast, double accelerationDown) ConvertAccelerationTBAToNED(double axialAcceleration, double lateralAcceleration, double verticalAcceleration, double headingAngle, double pitchAngle, double bankAngle)
        {
            var t = CalculateTransformationMatrix(headingAngle, pitchAngle, bankAngle);

            var accelerationTBA = new XYZ(axialAcceleration, lateralAcceleration, verticalAcceleration);

            var accelerationNED = t.Transpose() * accelerationTBA;

            return (accelerationNED.X, accelerationNED.Y, accelerationNED.Z);
        }
    }
}