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

        public List<int> GetMMSIs(DateTime startTime, DateTime endTime)
        {
            using var db = new AISDataContext();

            var mmsis = db.AISData.FilterByTime(startTime, endTime).Select(s => s.MMSI).Distinct().OrderBy(s => s).ToList();

            return mmsis;
        }

        public List<int> GetMMSIs(DateTime startTime, DateTime endTime, double latitudeMinDeg, double latitudeMaxDeg, double longitudeMinDeg, double longitudeMaxDeg)
        {
            using var db = new AISDataContext();

            var mmsis = db.AISData.FilterByTime(startTime, endTime).FilterByLatitudeLongitude(latitudeMinDeg, latitudeMaxDeg, longitudeMinDeg, longitudeMaxDeg).Select(s => s.MMSI).Distinct().OrderBy(s => s).ToList();

            return mmsis;
        }

        public List<AISData> GetAISData(DateTime startTime, DateTime endTime)
        {
            using var db = new AISDataContext();

            var aisData = db.AISData.FilterByTime(startTime, endTime).OrderByTime().ToList();

            return aisData;
        }

        public List<AISData> GetAISData(DateTime startTime, DateTime endTime, double latitudeMinDeg, double latitudeMaxDeg, double longitudeMinDeg, double longitudeMaxDeg)
        {
            using var db = new AISDataContext();

            var aisData = db.AISData.FilterByTime(startTime, endTime).FilterByLatitudeLongitude(latitudeMinDeg, latitudeMaxDeg, longitudeMinDeg, longitudeMaxDeg).OrderByTime().ToList();

            return aisData;
        }

        public List<AISData> GetAISData(int mmsi)
        {
            using var db = new AISDataContext();

            var aisData = db.AISData.FilterByMMSI(mmsi).ToList();

            return aisData;
        }

        public List<AISData> GetAISData(int mmsi, DateTime startTime, DateTime endTime)
        {
            using var db = new AISDataContext();

            var aisData = db.AISData.FilterByMMSI(mmsi).FilterByTime(startTime, endTime).OrderByTime().ToList(); ;

            return aisData;
        }

        public List<AISData> GetAISData(int mmsi, DateTime startTime, DateTime endTime, double latitudeMinDeg, double latitudeMaxDeg, double longitudeMinDeg, double longitudeMaxDeg)
        {
            using var db = new AISDataContext();

            var aisData = db.AISData.FilterByMMSI(mmsi).FilterByTime(startTime, endTime).FilterByLatitudeLongitude(latitudeMinDeg, latitudeMaxDeg, longitudeMinDeg, longitudeMaxDeg).OrderByTime().ToList(); ;

            return aisData;
        }
    }

    public static class Filters
    {
        public static IQueryable<AISData> FilterByMMSI(this IQueryable<AISData> query, int mmsi)
        {
            query = query.Where(s => s.MMSI == mmsi);

            return query;
        }

        public static IQueryable<AISData> FilterByTime(this IQueryable<AISData> query, DateTime startTime, DateTime endTime)
        {
            query = query.Where(s => s.TimeStamp >= startTime && s.TimeStamp <= endTime);

            return query;
        }

        public static IQueryable<AISData> FilterByLatitudeLongitude(this IQueryable<AISData> query, double latitudeMinDeg, double latitudeMaxDeg, double longitudeMinDeg, double longitudeMaxDeg)
        {
            query = query.Where(s => s.Latitude >= latitudeMinDeg && s.Latitude <= latitudeMaxDeg && s.Longitude >= longitudeMinDeg && s.Longitude <= longitudeMaxDeg);

            return query;
        }

        public static IQueryable<AISData> OrderByTime(this IQueryable<AISData> query)
        {
            query = query.OrderBy(s => s.TimeStamp);

            return query;
        }
    }
}