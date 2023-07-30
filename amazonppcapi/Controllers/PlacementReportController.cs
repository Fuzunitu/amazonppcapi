using amazonppcapi.Models;
using amazonppcapi.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace amazonppcapi.Controllers
{
    [ApiController]
    [Route("api/PlacementReport")]
    public class PlacementReportController : ControllerBase
    {
        private readonly MyDbContext _dbContext;
        public PlacementReportController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var users = _dbContext.PlacementReport.ToList();
            return Ok(users);//Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(PlacementReport environmentModel)
        {
            _dbContext.PlacementReport.Add(environmentModel);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }
    }
}
