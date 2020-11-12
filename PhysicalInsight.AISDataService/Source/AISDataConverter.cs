using PhysicalInsight.AISDataService.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhysicalInsight.AISDataService
{
    public static class AISDataConverter
    {
        public static AISData ConvertDatabaseAISDataToAISData(AISDatabase.AISData a)
        {
            var aisData = new AISData()
            {
                MMSI = a.MMSI,
                TimeStamp = a.TimeStamp,
                Latitude = a.Latitude,
                Longitude = a.Longitude,
                Name = a.Name,
                Callsign = a.Callsign,
            };

            return aisData;
        }
    }
}
