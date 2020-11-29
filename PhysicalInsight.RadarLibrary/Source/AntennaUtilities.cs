using static System.Math;

namespace PhysicalInsight.RadarLibrary
{
    public class AntennaUtilities
    {
        public static double GetAntennaGainFromAntennaEffectiveArea(double effectiveArea, double rfWavelength)
        {
            var antennaGain = (4 * PI * effectiveArea) / (rfWavelength * rfWavelength);

            return antennaGain;
        }

        public static double GetAntennaEffectiveAreaFromAntennaGain(double antennaGain, double rfWavelength)
        {
            var effectiveArea = (antennaGain * rfWavelength * rfWavelength) / (4 * PI);

            return effectiveArea;
        }
    }
}