﻿using static System.Math;

namespace PhysicalInsight.MathLibrary
{
    public static class UnitsOfMeasurement
    {
        // Angle
        public const double RadiansToDegrees = 180.0 / PI;

        public const double DegreesToRadians = 1 / RadiansToDegrees;

        public const double RpmToDegrees = 6.0;
        public const double DegreesToRpm = 1.0 / RpmToDegrees;

        // Length
        public const double MeterToFoot = 1 / FootToMeter;

        public const double FootToMeter = 0.3048;

        public const double MeterToKilometer = 1 / KilometerToMeter;
        public const double KilometerToMeter = 1000.0;

        public const double MeterToNauticalMile = 1 / NauticalMileToMeter;
        public const double NauticalMileToMeter = 1852.0;

        // Speed
        public const double MeterPerSecondToKnot = 3600.0 / NauticalMileToMeter;

        public const double KnotToMeterPerSecond = 1.0 / MeterPerSecondToKnot;

        // Acceleration
        public const double MeterPerSecondSquaredToG = 1.0 / GToMeterPerSecondSquared;

        public const double GToMeterPerSecondSquared = PhysicalConstants.GravitationalAcceleration;
    }
}