
namespace TariffComparisonAPI.Models
{
    public abstract class Product 
    {
        public abstract string Name { get; }

        public abstract double CalculateAnnualCost(int consumptionInKWhPerYear);

    }
}