using PhysicalInsight.AISDatabase;
using PhysicalInsight.AISDataService.Interfaces;
using System;
using System.Collections.Generic;

namespace PhysicalInsight.AISDataService
{
    public class AISDataProvider : IAISDataProvider
    {
        public IAISService AISService { get; set; } 

        public AISDataProvider(IAISService aisService)
        {
            AISService = aisService;
        }

        public List<Interfaces.AISData> GetAISData(DateTime currentTime)
        {
            throw new NotImplementedException();
        }
    }
}
