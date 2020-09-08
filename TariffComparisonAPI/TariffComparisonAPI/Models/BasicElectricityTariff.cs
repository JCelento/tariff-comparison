namespace TariffComparisonAPI.Models
{
    public class BasicElectricityTariff : Product
    {
        private const double baseCost = 5 * 12;

        private const double consumptionCostPerkWh = 0.22;

        private int ConsumptionInkWhPerYear { get; set; }

        public override string TariffName { get => "Basic electricity tariff"; }

        public override double AnnualCosts => CalculateAnnualCost(ConsumptionInkWhPerYear);


        public BasicElectricityTariff(int consumptionInkWhPerYear)
        {
            ConsumptionInkWhPerYear = consumptionInkWhPerYear;
        }


        public override double CalculateAnnualCost(int consumptionInKWhPerYear)
        {
            return baseCost + (consumptionInKWhPerYear * consumptionCostPerkWh);
        }
    }
}