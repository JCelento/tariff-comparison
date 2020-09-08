using Microsoft.VisualStudio.TestTools.UnitTesting;
using TariffComparisonAPI.Models;

namespace TariffComparisonAPI.Tests.Models
{
    [TestClass]
    public class BasicElectricityTariffTest
    {

        [TestMethod]
        public void BasicElectricityTariff_WhenGettingTariffName_ShouldBeBasicElectricityTariff()
        {
            var basicElectricityTariff = new BasicElectricityTariff(2000);

            Assert.AreEqual("Basic electricity tariff", basicElectricityTariff.TariffName);
        }

        [TestMethod]
        public void BasicElectricityTariff_WhenConsumptionIs0WhYear_AnnualCostsShouldBe60()
        {
            var basicElectricityTariff = new BasicElectricityTariff(0);

            Assert.AreEqual(60, basicElectricityTariff.AnnualCosts);
        }

        [TestMethod]
        public void BasicElectricityTariff_WhenConsumptionIs3500kWhYear_AnnualCostsShouldBe770()
        {
            var basicElectricityTariff = new BasicElectricityTariff(3500);

            Assert.AreEqual(830, basicElectricityTariff.AnnualCosts);
        }

        [TestMethod]
        public void BasicElectricityTariff_WhenConsumptionIs4500kWhYear_AnnualCostsShouldBe990()
        {
            var basicElectricityTariff = new BasicElectricityTariff(4500);

            Assert.AreEqual(1050, basicElectricityTariff.AnnualCosts);
        }

        [TestMethod]
        public void BasicElectricityTariff_WhenConsumptionIs6000kWhYear_AnnualCostsShouldBe1320()
        {
            var basicElectricityTariff = new BasicElectricityTariff(6000);

            Assert.AreEqual(1380, basicElectricityTariff.AnnualCosts);
        }

    }
}
