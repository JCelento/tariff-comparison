using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using TariffComparisonAPI.Controllers;

namespace TariffComparisonAPI.Tests.Controllers
{
    [TestClass]
    public class TariffComparisonControllerTest
    {
        [TestMethod]
        public void TariffComparisonController_WhenGettingAnnualCostFor0kWhPerYear_ShouldListBasicElectricityTariffAs60AndPackagedTariffAs800()
        {
            var tariffComparisonController = new TariffComparisonController();

            var result = tariffComparisonController.GetTariffComparison(0);

            Assert.AreEqual("Basic electricity tariff", result.First().TariffName);
            Assert.AreEqual(60, result.First().AnnualCosts);

            Assert.AreEqual("Packaged tariff", result.Last().TariffName);
            Assert.AreEqual(800, result.Last().AnnualCosts);
        }

        [TestMethod]
        public void TariffComparisonController_WhenGettingAnnualCostFor3500kWhPerYear_ShouldListBasicElectricityTariffAs830AndPackagedTariffAs800()
        {
            var tariffComparisonController = new TariffComparisonController();

            var result = tariffComparisonController.GetTariffComparison(3500);

            Assert.AreEqual("Packaged tariff", result.First().TariffName);
            Assert.AreEqual(800, result.First().AnnualCosts);

            Assert.AreEqual("Basic electricity tariff", result.Last().TariffName);
            Assert.AreEqual(830, result.Last().AnnualCosts);
        }

        [TestMethod]
        public void TariffComparisonController_WhenGettingAnnualCostFor4500kWhPerYear_ShouldListBasicElectricityTariffAs1050AndPackagedTariffAs950()
        {
            var tariffComparisonController = new TariffComparisonController();

            var result = tariffComparisonController.GetTariffComparison(4500);

            Assert.AreEqual("Packaged tariff", result.First().TariffName);
            Assert.AreEqual(950, result.First().AnnualCosts);

            Assert.AreEqual("Basic electricity tariff", result.Last().TariffName);
            Assert.AreEqual(1050, result.Last().AnnualCosts);
        }

        [TestMethod]
        public void TariffComparisonController_WhenGettingAnnualCostFor6000kWhPerYear_ShouldListBasicElectricityTariffAs1380AndPackagedTariffAs1400()
        {
            var tariffComparisonController = new TariffComparisonController();

            var result = tariffComparisonController.GetTariffComparison(6000);

            Assert.AreEqual("Basic electricity tariff", result.First().TariffName);
            Assert.AreEqual(1380, result.First().AnnualCosts);

            Assert.AreEqual("Packaged tariff", result.Last().TariffName);
            Assert.AreEqual(1400, result.Last().AnnualCosts);
        }
    }
}
