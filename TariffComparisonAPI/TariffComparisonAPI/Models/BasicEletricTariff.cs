namespace TariffComparisonAPI.Models
{
    public class BasicEletricTariff : Product
    {
        public override string Name { get => "Basic eletric tariff"; }

        private const double baseCost = 5 * 12;

        private const double consumptionCostPerKWh = 0.22;

        public override double CalculateAnnualCost(int consumptionInKWhPerYear)
        {
            return baseCost + (consumptionInKWhPerYear * consumptionCostPerKWh);
        }
    }
}