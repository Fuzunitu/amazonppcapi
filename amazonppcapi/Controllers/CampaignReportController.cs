using amazonppcapi.Models;
using amazonppcapi.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace amazonppcapi.Controllers
{
    [ApiController]
    [Route("api/CampaignReport")]
    public class CampaignReportController : ControllerBase
    {
        private readonly MyDbContext _dbContext;
        public CampaignReportController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var users = _dbContext.CampaignReport.ToList();
            return Ok(users);//Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CampaignReport environmentModel)
        {
            _dbContext.CampaignReport.Add(environmentModel);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }
    }
}
