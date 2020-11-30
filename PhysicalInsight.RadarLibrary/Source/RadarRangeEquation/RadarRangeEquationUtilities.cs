using static PhysicalInsight.MathLibrary.PhysicalConstants;
using static System.Math;

namespace PhysicalInsight.RadarLibrary
{
    public class RadarRangeEquationUtilities
    {
        public static (double signalPower, double noisePower, double signalToNoiseRatio) CalculateSignalToNoiseRatio(double transmitPower, double pulseDuration, double pulseBandwidth, double numberOfPulses, double transmitGain, double receiveGain, double wavelength, double radarCrossSection, double range, double losses, double systemNoiseFigure)
        {
            return CalculateSignalToNoisePowerRatio(transmitPower, pulseDuration, pulseBandwidth, numberOfPulses, transmitGain, receiveGain, wavelength, radarCrossSection, range, losses, systemNoiseFigure);
        }

        public static (double signalPower, double noisePower, double signalToNoiseRatio) CalculateSignalToNoisePowerRatio(double transmitPower, double pulseDuration, double pulseBandwidth, double numberOfPulses, double transmitGain, double receiveGain, double wavelength, double radarCrossSection, double range, double losses, double systemNoiseFigure)
        {
            var signalPower = CalculateSignalPower(transmitPower, pulseDuration, pulseBandwidth, numberOfPulses, transmitGain, receiveGain, wavelength, radarCrossSection, range, losses);
            var noisePower = CalculateNoisePower(systemNoiseFigure, pulseBandwidth);

            var signalToNoiseRatio = signalPower / noisePower;

            return (signalPower, noisePower, signalToNoiseRatio);
        }

        public static (double signalEnergy, double noiseEnergy, double signalToNoiseRatio) CalculateSignalToNoiseEnergyRatio(double transmitPower, double pulseDuration, double numberOfPulses, double transmitGain, double receiveGain, double wavelength, double radarCrossSection, double range, double losses, double systemNoiseFigure)
        {
            var signalEnergy = CalculateSignalEnergy(transmitPower, pulseDuration, numberOfPulses, transmitGain, receiveGain, wavelength, radarCrossSection, range, losses);
            var noiseEnergy = CalculateNoiseEnergy(systemNoiseFigure);

            var signalToNoiseRatio = signalEnergy / noiseEnergy;

            return (signalEnergy, noiseEnergy, signalToNoiseRatio);
        }

        public static double CalculateSignalEnergy(double transmitPower, double pulseDuration, double numberOfPulses, double transmitGain, double receiveGain, double wavelength, double radarCrossSection, double range, double losses)
        {
            var numerator = transmitPower * pulseDuration * transmitGain * receiveGain * Pow(wavelength, 2) * radarCrossSection * numberOfPulses;
            var denominator = Pow((4 * PI), 3) * Pow(range, 4) * losses;

            var signalEnergy = numerator / denominator;

            return signalEnergy;
        }

        public static double CalculateNoiseEnergy(double noiseFigure)
        {
            var noiseEnergy = BoltzmannConstant * SystemReferenceTemperature * noiseFigure;

            return noiseEnergy;
        }

        public static double CalculateSignalPower(double transmitPower, double pulseDuration, double pulseBandwidth, double numberOfPulses, double transmitGain, double receiveGain, double wavelength, double radarCrossSection, double range, double losses)
        {
            var signalEnergy = CalculateSignalEnergy(transmitPower, pulseDuration, numberOfPulses, transmitGain, receiveGain, wavelength, radarCrossSection, range, losses);

            var signalPower = signalEnergy * pulseBandwidth;

            return signalPower;
        }

        public static double CalculateNoisePower(double noiseFigure, double bandwidth)
        {
            var systemNoisePower = CalculateNoiseEnergy(noiseFigure) * bandwidth;

            return systemNoisePower;
        }
    }
}