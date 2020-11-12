using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalInsight.AISDatabase.Tests
{
    [TestClass]
    public class AISServiceTests
    {
        [TestMethod]
        public void GetByMMSI()
        {
            // Arrange:
            var mmsi = 219001182;

            var aisService = new AISService();

            // Act:
            var aisData = aisService.GetAISDataByMMSI(mmsi);

            // Assert:
        }

        [TestMethod]
        public void GetByMMSIAndDate()
        {
            // Arrange:
            var mmsi = 219018172;

            var aisService = new AISService();

            var startTime = new DateTime(2018, 11, 02, 10, 00, 00);
            var endTime = startTime.AddSeconds(100);

            // Act:
            var aisData = aisService.GetAISDataByMMSI(mmsi, startTime, endTime);

            // Assert:
        }
    }
}