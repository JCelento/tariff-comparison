using System.Collections.Generic;
using System.Web.Http;
using TariffComparisonAPI.Models;
using TariffComparisonAPI.Services;

namespace TariffComparisonAPI.Controllers
{
    public class TariffComparisonController : ApiController
    {
        private readonly TariffComparisonService tariffComparisonService;

        public TariffComparisonController()
        {
            tariffComparisonService = new TariffComparisonService();
        }

        public List<Product> GetTariffComparison(int consumption)
        {
            return tariffComparisonService.GetTariffComparison(consumption);
        }
    }
}
