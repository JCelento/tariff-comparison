using System.Collections.Generic;
using System.Linq;
using TariffComparisonAPI.Models;

namespace TariffComparisonAPI.Services
{
    public class TariffComparisonService
    {
        private List<Product> products;


        public TariffComparisonService()
        {
            products = new List<Product>();
        }


        public List<Product> GetTariffComparison(int consumptionInkWhPerYear)
        {
            products.Add(new BasicEletricTariff(consumptionInkWhPerYear));
            products.Add(new PackagedTariff(consumptionInkWhPerYear));

           return products.OrderBy(product => product.AnnualCosts).ToList();

        }


    }
}