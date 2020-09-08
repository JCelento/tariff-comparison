namespace TariffComparisonAPI.Models
{
    public class BasicEletricTariff : Product
    {
        private const double baseCost = 5 * 12;

        private const double consumptionCostPerkWh = 0.22;

        private int ConsumptionInkWhPerYear { get; set; }

        public override string TariffName { get => "Basic eletric tariff"; }

        public override double AnnualCosts => CalculateAnnualCost(ConsumptionInkWhPerYear);


        public BasicEletricTariff(int consumptionInkWhPerYear)
        {
            ConsumptionInkWhPerYear = consumptionInkWhPerYear;
        }


        public override double CalculateAnnualCost(int consumptionInKWhPerYear)
        {
            return baseCost + (consumptionInKWhPerYear * consumptionCostPerkWh);
        }
    }
}