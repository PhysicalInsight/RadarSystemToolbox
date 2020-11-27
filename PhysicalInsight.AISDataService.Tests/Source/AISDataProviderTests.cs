using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhysicalInsight.AISDatabase;
using Shouldly;
using System;

namespace PhysicalInsight.AISDataService.Tests
{
    [TestClass]
    public class AISDataProviderTests
    {
        [TestMethod]
        public void GetAISData()
        {
            // Arrange:
            var aisService = new AISService();

            var aisDataProvider = new AISDataProvider(aisService);

            var currentTime = new DateTime(2020, 11, 01, 10, 00, 00);

            var expectedCount = 1645;

            // Act:
            var aisData = aisDataProvider.GetAISData(currentTime);

            // Assert:
            aisData.Count.ShouldBe(expectedCount);
        }
    }
}