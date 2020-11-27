using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
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
            var mmsi = 219461000;

            var aisService = new AISService();

            var expectedCount = 9193;

            // Act:
            var aisData = aisService.GetAISData(mmsi);

            // Assert:
            aisData.Count.ShouldBe(expectedCount);
        }

        [TestMethod]
        public void GetByMMSIAndDate()
        {
            // Arrange:
            var mmsi = 219461000;

            var aisService = new AISService();

            var startTime = new DateTime(2020, 11, 01, 10, 00, 00);

            var endTime = startTime.AddSeconds(100);

            var expectedCount = 10;

            // Act:
            var aisData = aisService.GetAISData(mmsi, startTime, endTime);

            // Assert:
            aisData.Count.ShouldBe(expectedCount);
        }
    }
}