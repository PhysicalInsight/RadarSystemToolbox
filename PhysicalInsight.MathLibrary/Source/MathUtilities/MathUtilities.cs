using static System.Math;

namespace PhysicalInsight.MathLibrary
{
    public static class MathUtilities
    {
        public static double GetTotalSpeed(double velocityX, double velocityY, double velocityZ)
        {
            var totalSpeed = Sqrt(velocityX * velocityX + velocityY * velocityY + velocityZ * velocityZ);

            return totalSpeed;
        }

        public static double GetGroundSpeed(double velocityX, double velocityY)
        {
            var groundSpeed = Sqrt(velocityX * velocityX + velocityY * velocityY);

            return groundSpeed;
        }

        public static double GetCourseOverGround(double velocityX, double velocityY)
        {
            var courseOverGround = Atan2(velocityY, velocityX);

            return courseOverGround;
        }

        public static double GetVerticalVelocityAngle(double velocityZ, double groundSpeed)
        {
            var verticalVelocityAngle = Atan2(velocityZ, groundSpeed);

            return verticalVelocityAngle;
        }

        public static double ConvertAngleInDegreesToPlusMinus180(double angleDeg)
        {
            var angleDegConstrained = angleDeg;

            if (angleDeg > 180)
            {
                angleDegConstrained = angleDeg - 360.0;
            }

            if (angleDeg < -180)
            {
                angleDegConstrained = angleDeg + 360.0;
            }

            return angleDegConstrained;
        }

        public static double AzimuthDifferenceDegrees(double angle1Deg, double angle2Deg)
        {
            var azDifferenceDeg = angle1Deg - angle2Deg;

            azDifferenceDeg = ConvertAngleInDegreesToPlusMinus180(azDifferenceDeg);

            return azDifferenceDeg;
        }
    }
}