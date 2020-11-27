using System;
using System.Collections.Generic;

namespace PhysicalInsight.AISDataService.Interfaces
{
    public interface IAISDataProvider
    {
        public List<AISData> GetAISData(DateTime currentTime);
    }
}