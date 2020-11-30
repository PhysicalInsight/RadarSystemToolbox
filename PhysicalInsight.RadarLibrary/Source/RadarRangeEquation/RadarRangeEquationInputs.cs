using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PhysicalInsight.MathLibrary;

namespace PhysicalInsight.RadarLibrary
{
    public record RadarRangeEquationInputs
    {
        public double TransmitFrequency { get; init; }

        public double TransmitWavelength => TransmitFrequency.FrequencyToWavelength();

        public double TransmitPower { get; init; }

        public double PulseDuration { get; init; }

        public double PulseBandwidth { get; init; }

        public int NumberOfPulses { get; init; }

        public double TransmitAntennaGain => TransmitAntennaGain_dB.FromDecibels();

        public double TransmitAntennaGain_dB { get; init; }

        public double TargetRange { get; init; }

        public double TargetRange_NM => TargetRange.ToNauticalMile();

        public double TargetRadarCrossSection { get; init; }

        public double TargetRadarCrossSection_dB => TargetRadarCrossSection.ToDecibels();

        public double ReceiveAntennaGain => ReceiveAntennaGain_dB.FromDecibels();

        public double ReceiveAntennaGain_dB { get; init; }

        public double SystemNoiseFigure => SystemNoiseFigure_dB.FromDecibels();

        public double SystemNoiseFigure_dB { get; init; }

        public double SystemLosses => SystemLosses_dB.FromDecibels();

        public double SystemLosses_dB { get; init; }


    }
}
