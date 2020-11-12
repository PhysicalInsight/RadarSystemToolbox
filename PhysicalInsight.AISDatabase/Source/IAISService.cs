using System;
using System.Collections.Generic;

namespace PhysicalInsight.AISDatabase
{
    public interface IAISService
    {
        List<AISData> GetAISData(DateTime startTime, DateTime endTime);

        List<AISData> GetAISData(DateTime startTime, DateTime endTime, double latitudeMinDeg, double latitudeMaxDeg, double longitudeMinDeg, double longitudeMaxDeg);

        List<AISData> GetAISDataByMMSI(int mmsi);

        List<AISData> GetAISDataByMMSI(int mmsi, DateTime startTime, DateTime endTime);

        List<int> GetMMSIs(DateTime startTime, DateTime endTime);

        List<int> GetMMSIs(DateTime startTime, DateTime endTime, double latitudeMinDeg, double latitudeMaxDeg, double longitudeMinDeg, double longitudeMaxDeg);
    }
}