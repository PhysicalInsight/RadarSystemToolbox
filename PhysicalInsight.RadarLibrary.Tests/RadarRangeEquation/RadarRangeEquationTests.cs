using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace PhysicalInsight.RadarLibrary.Tests
{
    [TestClass]
    public class RadarRangeEquationTests
    {
        [TestMethod]
        public void CalculateSignalPower_1()
        {
            // Arrange;
            var radarRangeEquation = new RadarRangeEquation();

            var inputs = new RadarRangeEquationInputs()
            {
                TransmitFrequency = 9.5e9,
                TransmitPower = 8000,
                PulseDuration = 1.0e-6,
                PulseBandwidth = 5.0e6,
                NumberOfPulses = 1000,
                TransmitAntennaGain_dB = 35.0,
                TargetRange = 100.0e3,
                TargetRadarCrossSection = 5.0,
                ReceiveAntennaGain_dB = 35.0,
                SystemLosses_dB = 8.0,
                SystemNoiseFigure_dB = 3.0
            };

            var expectedSignalToNoiseRatio_dB = 16.007445685340819;

            // Act:
            var outputs = radarRangeEquation.CalculateSignalPower(inputs);

            // Assert:
            outputs.SignalToNoiseRatio_dB.ShouldBe(expectedSignalToNoiseRatio_dB);
        }
    }
}
