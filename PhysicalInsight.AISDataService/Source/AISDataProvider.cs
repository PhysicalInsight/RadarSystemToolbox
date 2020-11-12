using PhysicalInsight.AISDataService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PhysicalInsight.AISDataService
{
    public class AISDataProvider : IAISDataProvider
    {
        public AISDatabase.IAISService AISService { get; set; }
        
        public List<AISData> AISDataCache { get; set; }

        public List<List<AISData>> AISDataCachePerMMSI { get; set; }


        public AISDataProvider(AISDatabase.IAISService aisService)
        {
            AISService = aisService;
        }

        public List<AISData> GetAISData(DateTime currentTime)
        {
            if (IsUpdateAISDataCache(currentTime))
            {
                UpdateAISDataCache(currentTime);
            }

            var aisData = GetAISDataFromCache(currentTime);

            return aisData;
        }

        private bool IsUpdateAISDataCache(DateTime currentTime)
        {
            bool isUpdateAISDataCache = AISDataCache is null || AISDataCache.LastOrDefault().TimeStamp <= currentTime;

            return isUpdateAISDataCache;
        }

        private void UpdateAISDataCache(DateTime currentTime)
        {
            var startTime = currentTime.AddSeconds(-100);
            var endTime = currentTime.AddSeconds(200);

            var aisData2 = AISService.GetAISData(startTime, endTime, 0, 90, 0, 30);

            var mmsis = aisData2.Select(s => s.MMSI).Distinct().OrderBy(s => s).ToList();

            AISDataCachePerMMSI = new List<List<AISData>>();

            foreach (var mmsi in mmsis)
            {
                var a = aisData2.Where(s => s.MMSI == mmsi);

                var aisData = a.Select(s => AISDataConverter.ConvertDatabaseAISDataToAISData(s)).ToList();

                AISDataCachePerMMSI.Add(aisData);
            }
        }

        private List<AISData> GetAISDataFromCache(DateTime currentTime)
        {
            var aisData = new List<AISData>();

            foreach (var a in AISDataCachePerMMSI)
            {
                var a2 = a.Where(s => s.TimeStamp < currentTime).LastOrDefault();

                if (!(a2 is null))
                {
                    aisData.Add(a2);
                }
            }

            return aisData;
        }
    }
}
