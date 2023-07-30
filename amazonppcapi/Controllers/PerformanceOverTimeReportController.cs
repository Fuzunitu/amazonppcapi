using amazonppcapi.Models;
using amazonppcapi.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace amazonppcapi.Controllers
{
    [ApiController]
    [Route("api/PerformanceOverTimeReport")]
    public class PerformanceOverTimeReportController : ControllerBase
    {
        private readonly MyDbContext _dbContext;
        public PerformanceOverTimeReportController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var users = _dbContext.PerformanceOverTimeReport.ToList();
            return Ok(users);//Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(PerformanceOverTimeReport environmentModel)
        {
            _dbContext.PerformanceOverTimeReport.Add(environmentModel);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }
    }
}
