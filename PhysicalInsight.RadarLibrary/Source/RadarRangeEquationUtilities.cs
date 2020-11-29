using static PhysicalInsight.MathLibrary.PhysicalConstants;
using static System.Math;

namespace PhysicalInsight.RadarLibrary
{
    public class RadarRangeEquationUtilities
    {
        public static double CalculateSignalToNoiseRatio(double transmitPower, double pulseDuration, double transmitGain, double receiveGain, double wavelength, double radarCrossSection, double range, double losses, double systemNoiseFigure)
        {
            var signalEnergy = CalculateSignalEnergy(transmitPower, pulseDuration, transmitGain, receiveGain, wavelength, radarCrossSection, range, losses);
            var noiseEnergy = CalculateNoiseEnergy(systemNoiseFigure);

            var signalToNoiseRatio = signalEnergy / noiseEnergy;

            return signalToNoiseRatio;
        }

        public static double CalculateSignalEnergy(double transmitPower, double pulseDuration, double transmitGain, double receiveGain, double wavelength, double radarCrossSection, double range, double losses)
        {
            var numerator = transmitPower * pulseDuration * transmitGain * receiveGain * Pow(wavelength, 2) * radarCrossSection;
            var denominator = Pow((4 * PI), 3) * Pow(range, 4) * losses;

            var signalEnergy = numerator / denominator;

            return signalEnergy;
        }

        public static double CalculateNoiseEnergy(double noiseFigure)
        {
            var noiseEnergy = BoltzmannConstant * SystemReferenceTemperature * noiseFigure;

            return noiseEnergy;
        }

        public static double CalculateSignalPower(double transmitPower, double pulseDuration, double pulseCompressionRatio, double transmitGain, double receiveGain, double wavelength, double radarCrossSection, double range, double losses)
        {
            var signalEnergy = CalculateSignalEnergy(transmitPower, pulseDuration, transmitGain, receiveGain, wavelength, radarCrossSection, range, losses);

            var signalPower = signalEnergy / pulseDuration * pulseCompressionRatio;

            return signalPower;
        }

        public static double CalculateNoisePower(double noiseFigure, double bandwidth)
        {
            var systemNoisePower = CalculateNoiseEnergy(noiseFigure) * bandwidth;

            return systemNoisePower;
        }
    }
}