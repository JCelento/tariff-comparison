using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using TariffComparisonAPI.Services;

namespace TariffComparisonAPI.Tests.Services
{
    [TestClass]
    public class TariffComparisonServiceTest
    {

        [TestMethod]
        public void TariffComparisonService_WhenConsumptionIs0kWh_BasicElectricityTariffShouldBeTheFirstListed()
        {
            var tariffComparisonService = new TariffComparisonService();

            var result = tariffComparisonService.GetTariffComparison(0);

            Assert.AreEqual("Basic electricity tariff", result.First().TariffName);
        }

        [TestMethod]
        public void TariffComparisonService_WhenConsumptionIs3500kWh_PackagedTariffShouldBeTheFirstListed()
        {
            var tariffComparisonService = new TariffComparisonService();

            var result = tariffComparisonService.GetTariffComparison(3500);

            Assert.AreEqual("Packaged tariff", result.First().TariffName);
        }

        [TestMethod]
        public void TariffComparisonService_WhenConsumptionIs4500kWh_PackagedTariffShouldBeTheFirstListed()
        {
            var tariffComparisonService = new TariffComparisonService();

            var result = tariffComparisonService.GetTariffComparison(4500);

            Assert.AreEqual("Packaged tariff", result.First().TariffName);
        }

        [TestMethod]
        public void TariffComparisonService_WhenConsumptionIs6000kWh_BasicElectricityTariffShouldBeTheFirstListed()
        {
            var tariffComparisonService = new TariffComparisonService();

            var result = tariffComparisonService.GetTariffComparison(6000);

            Assert.AreEqual("Basic electricity tariff", result.First().TariffName);
        }

    }
}
