using amazonppcapi.Models;
using amazonppcapi.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace amazonppcapi.Controllers
{
    [ApiController]
    [Route("api/PurchasedProductReport")]
    public class PurchasedProductReportController : ControllerBase
    {
        private readonly MyDbContext _dbContext;
        public PurchasedProductReportController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var users = _dbContext.PurchasedProductReport.ToList();
            return Ok(users);//Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(PurchasedProductReport environmentModel)
        {
            _dbContext.PurchasedProductReport.Add(environmentModel);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }
    }
}
