using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalInsight.RadarLibrary
{
    public class RadarRangeEquation : IRadarRangeEquation
    {
        public RadarRangeEquation()
        {
        }

        public RadarRangeEquationOutputs CalculateSignalPower(RadarRangeEquationInputs inputs)
        {
            var (signalPower, noisePower, signalToNoiseRatio) = RadarRangeEquationUtilities.CalculateSignalToNoiseRatio(inputs.TransmitPower, inputs.PulseDuration, inputs.PulseBandwidth, inputs.NumberOfPulses, inputs.TransmitAntennaGain, inputs.ReceiveAntennaGain, inputs.TransmitWavelength, inputs.TargetRadarCrossSection, inputs.TargetRange, inputs.SystemLosses, inputs.SystemNoiseFigure);

            var outputs = new RadarRangeEquationOutputs()
            {
                SignalPower = signalPower,
                NoisePower = noisePower,
                SignalToNoiseRatio = signalToNoiseRatio
            };

            return outputs;
        }
    }
}
