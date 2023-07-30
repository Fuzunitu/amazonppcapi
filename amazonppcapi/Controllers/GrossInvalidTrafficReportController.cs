using amazonppcapi.Models;
using amazonppcapi.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace amazonppcapi.Controllers
{
    [ApiController]
    [Route("api/GrossInvalidTrafficReport")]
    public class GrossInvalidTrafficReportController : ControllerBase
    {
        private readonly MyDbContext _dbContext;
        public GrossInvalidTrafficReportController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var users = _dbContext.GrossInvalidTrafficReport.ToList();
            return Ok(users);//Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(GrossInvalidTrafficReport environmentModel)
        {
            _dbContext.GrossInvalidTrafficReport.Add(environmentModel);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }
    }
}
