namespace PhysicalInsight.RadarLibrary
{
    public interface IRadarRangeEquation
    {
        RadarRangeEquationOutputs CalculateSignalPower(RadarRangeEquationInputs inputs);
    }
}