using System;
using System.Collections.Generic;

namespace PhysicalInsight.AISDatabase
{
    public interface IAISService
    {
        List<AISData> GetByMMSI(int mmsi);

        List<AISData> GetByMMSI(int mmsi, DateTime startTime, DateTime endTime);

        List<int> GetMMSIs(DateTime startTime, DateTime endTime);

        List<int> GetMMSIs(DateTime startTime, DateTime endTime, double latitudeMinDeg, double latitudeMaxDeg, double longitudeMinDeg, double longitudeMaxDeg);
    }
}