namespace TariffComparisonAPI.Models
{
    public abstract class Product 
    {
        public abstract string TariffName { get; }

        public abstract double CalculateAnnualCost(int consumptionInKWhPerYear);

        public abstract double AnnualCosts { get; }

    }
}