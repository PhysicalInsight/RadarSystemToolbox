using System;
using System.Collections.Generic;
using System.Linq;

namespace PhysicalInsight.AISDatabase
{
    public class AISService : IAISService
    {
        public AISService()
        {
        }

        public List<AISData> GetAISData(DateTime startTime, DateTime endTime)
        {
            using (var db = new AISDataContext())
            {
                var aisData = db.AISData.Where(s => s.TimeStamp >= startTime && s.TimeStamp <= endTime).OrderBy(s => s.TimeStamp).ToList();

                return aisData;
            }
        }

        public List<AISData> GetAISData(DateTime startTime, DateTime endTime, double latitudeMinDeg, double latitudeMaxDeg, double longitudeMinDeg, double longitudeMaxDeg)
        {
            using (var db = new AISDataContext())
            {
                var a = db.AISData.Where(s => s.TimeStamp >= startTime && s.TimeStamp <= endTime && s.Latitude >= latitudeMinDeg && s.Latitude <= latitudeMaxDeg && s.Longitude >= longitudeMinDeg && s.Longitude <= longitudeMaxDeg);

                var aisData = db.AISData.Where(s => s.TimeStamp >= startTime && s.TimeStamp <= endTime && s.Latitude >= latitudeMinDeg && s.Latitude <= latitudeMaxDeg && s.Longitude >= longitudeMinDeg && s.Longitude <= longitudeMaxDeg).Select(s => s).OrderBy(s => s.MMSI).ToList();

                return aisData;
            }
        }
        public List<AISData> GetAISDataByMMSI(int mmsi)
        {
            using (var db = new AISDataContext())
            {
                var aisData = db.AISData.Where(s => s.MMSI == mmsi).OrderBy(s => s.TimeStamp).ToList();

                return aisData;
            }
        }

        public List<AISData> GetAISDataByMMSI(int mmsi, DateTime startTime, DateTime endTime)
        {
            using (var db = new AISDataContext())
            {
                var aisData = db.AISData.Where(s => s.MMSI == mmsi && s.TimeStamp >= startTime && s.TimeStamp <= endTime).OrderBy(s => s.TimeStamp).ToList();

                return aisData;
            }
        }

        public List<int> GetMMSIs(DateTime startTime, DateTime endTime)
        {
            using (var db = new AISDataContext())
            {
                var mmsis = db.AISData.Where(s => s.TimeStamp >= startTime && s.TimeStamp <= endTime).Select(s => s.MMSI).Distinct().OrderBy(s => s).ToList();

                return mmsis;
            }
        }

        public List<int> GetMMSIs(DateTime startTime, DateTime endTime, double latitudeMinDeg, double latitudeMaxDeg, double longitudeMinDeg, double longitudeMaxDeg)
        {
            using (var db = new AISDataContext())
            {
                var mmsis = db.AISData.Where(s => s.TimeStamp >= startTime && s.TimeStamp <= endTime && s.Latitude >= latitudeMinDeg && s.Latitude <= latitudeMaxDeg && s.Longitude >= longitudeMinDeg && s.Longitude <= longitudeMaxDeg).Select(s => s.MMSI).Distinct().OrderBy(s => s).ToList();

                return mmsis;
            }
        }
    }
}