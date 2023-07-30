using amazonppcapi.Models;
using amazonppcapi.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace amazonppcapi.Controllers
{
    [ApiController]
    [Route("api/SearchTermsReport")]
    public class SearchTermReportController : ControllerBase
    {
        private readonly MyDbContext _dbContext;
        public SearchTermReportController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var users = _dbContext.SearchTermsReport.ToList();
            return Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(SearchTermReport environmentModel)
        {
            _dbContext.SearchTermsReport.Add(environmentModel);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }
    }
}
