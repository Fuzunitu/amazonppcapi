using amazonppcapi.Models;
using amazonppcapi.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace amazonppcapi.Controllers
{
    [ApiController]
    [Route("api/AdvertisedProductsReports")]
    public class BaseController : ControllerBase
    {
        private readonly MyDbContext _dbContext;
        public BaseController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var users = _dbContext.AdvertisedProductsReports.ToList();
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
