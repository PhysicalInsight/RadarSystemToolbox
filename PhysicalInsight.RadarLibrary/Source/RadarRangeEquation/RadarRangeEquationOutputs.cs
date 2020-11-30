using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhysicalInsight.MathLibrary;

namespace PhysicalInsight.RadarLibrary
{
    public record RadarRangeEquationOutputs
    {
        public double SignalPower { get; init; }

        public double SignalPower_dB => SignalPower.ToDecibels();

        public double SignalPower_dBm => SignalPower_dB.DecibelsToDBm();

        public double NoisePower { get; init; }

        public double NoisePower_dB => NoisePower.ToDecibels();

        public double NoisePower_dBm => NoisePower_dB.DecibelsToDBm();

        public double SignalToNoiseRatio { get; init; }

        public double SignalToNoiseRatio_dB => SignalToNoiseRatio.ToDecibels();
    }
}
