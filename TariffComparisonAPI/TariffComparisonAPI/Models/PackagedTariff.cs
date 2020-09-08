namespace TariffComparisonAPI.Models
{
    public class PackagedTariff : Product
    {
        private const double baseCost = 800;

        private const double consumptionCostPerExtraKWh = 0.30;

        private const int packageMaximumConsumption = 4000;

        private int ConsumptionInkWhPerYear { get; set; }

        public override string TariffName { get => "Packaged tariff"; }

        public override double AnnualCosts => CalculateAnnualCost(ConsumptionInkWhPerYear);


        public PackagedTariff(int consumptionInkWhPerYear)
        {
            ConsumptionInkWhPerYear = consumptionInkWhPerYear;
        }


        public override double CalculateAnnualCost(int consumptionInKWhPerYear)
        {
            if (consumptionInKWhPerYear <= packageMaximumConsumption)
                return baseCost;

            return baseCost + ((consumptionInKWhPerYear - packageMaximumConsumption) * consumptionCostPerExtraKWh);
        }
    }
}