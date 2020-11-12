using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhysicalInsight.AISDatabase;
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

            var currentTime = new DateTime(2018, 11, 02, 10, 00, 00);

            // Act:
            aisDataProvider.GetAISData(currentTime);

            // Assert:
            Assert.Inconclusive();
        }
    }
}
