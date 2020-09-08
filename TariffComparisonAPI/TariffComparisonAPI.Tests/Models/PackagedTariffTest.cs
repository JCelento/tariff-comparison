using Microsoft.VisualStudio.TestTools.UnitTesting;
using TariffComparisonAPI.Models;

namespace TariffComparisonAPI.Tests.Models
{
    [TestClass]
    public class PackagedTariffTest
    {

        [TestMethod]
        public void PackagedTariff_WhenGettingTariffName_ShouldBePackagedTariff()
        {
            var packagedTariff = new PackagedTariff(1000);

            Assert.AreEqual("Packaged tariff", packagedTariff.TariffName);
        }

        [TestMethod]
        public void PackagedTariff_WhenConsumptionIs0WhYear_AnnualCostsShouldBe800()
        {
            var packagedTariff = new PackagedTariff(0);

            Assert.AreEqual(800, packagedTariff.AnnualCosts);
        }

        [TestMethod]
        public void PackagedTariff_WhenConsumptionIs3500kWhYear_AnnualCostsShouldBe800()
        {
            var packagedTariff = new PackagedTariff(3500);

            Assert.AreEqual(800, packagedTariff.AnnualCosts);
        }

        [TestMethod]
        public void PackagedTariff_WhenConsumptionIs4500kWhYear_AnnualCostsShouldBe950()
        {
            var packagedTariff = new PackagedTariff(4500);

            Assert.AreEqual(950, packagedTariff.AnnualCosts);
        }

        [TestMethod]
        public void PackagedTariff_WhenConsumptionIs6000kWhYear_AnnualCostsShouldBe1400()
        {
            var packagedTariff = new PackagedTariff(6000);

            Assert.AreEqual(1400, packagedTariff.AnnualCosts);
        }

    }
}
