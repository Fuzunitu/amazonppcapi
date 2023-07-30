using amazonppcapi.Models;
using amazonppcapi.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace amazonppcapi.Controllers
{
    [ApiController]
    [Route("api/SearchTermImpressionShareReport")]
    public class SearchTermImpressionShareReportController : ControllerBase
    {
        private readonly MyDbContext _dbContext;
        public SearchTermImpressionShareReportController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var users = _dbContext.SearchTermImpressionShareReport.ToList();
            return Ok(users);//Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(AdvertisedProductReport environmentModel)
        {
            _dbContext.AdvertisedProductsReports.Add(environmentModel);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }
    }
}
