using PhysicalInsight.AISDataService.Interfaces;
using System;
using System.Collections.Generic;

namespace PhysicalInsight.AISDataService
{
    public class AISDataManager
    {
        public List<IAISDataProvider> AISDataProviders { get; set; }

        public AISDataManager()
        {
        }

        public List<AISData> GetAISData(DateTime currentTime)
        {
            var aisDataAll = new List<AISData>();

            foreach (var provider in AISDataProviders)
            {
                var aisData = provider.GetAISData(currentTime);

                aisDataAll.AddRange(aisData);
            }

            return aisDataAll;
        }
    }
}