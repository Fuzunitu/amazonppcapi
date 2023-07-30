using amazonppcapi.Models;
using amazonppcapi.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace amazonppcapi.Controllers
{
    [ApiController]
    [Route("api/TargetingReport")]
    public class TargetingReportController : ControllerBase
    {
        private readonly MyDbContext _dbContext;
        public TargetingReportController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        [HttpGet]
        public IActionResult GetProducts()
        {
            var users = _dbContext.TargetingReport.ToList();
            return Ok(users);//Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(TargetingReport environmentModel)
        {
            _dbContext.TargetingReport.Add(environmentModel);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }
    }
}
