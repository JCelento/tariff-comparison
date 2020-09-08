namespace TariffComparisonAPI.Models
{
    public class PackagedTariff : Product
    {
        public override string Name { get => "Packaged tariff"; }

        private const double baseCost = 800;

        private const double consumptionCostPerExtraKWh = 0.30;

        private const int packageMaximumConsumption = 4000;

        public override double CalculateAnnualCost(int consumptionInKWhPerYear)
        {
            if (consumptionInKWhPerYear <= packageMaximumConsumption)
                return baseCost;

            return baseCost + ((consumptionInKWhPerYear - packageMaximumConsumption) * consumptionCostPerExtraKWh);
        }
    }
}