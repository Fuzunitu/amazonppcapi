using amazonppcapi.Models;
using amazonppcapi.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace amazonppcapi.Controllers
{

    [ApiController]
    [Route("api/base")]
    public class BudgetReportController
    {
        private readonly MyDbContext _dbContext;
        public BudgetReportController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var users = _dbContext.BudgetReport.ToList();
            return null;//Ok(users);
        }


        [HttpPost]
        public async Task<IActionResult> CreateProduct(BudgetReport environmentModel)
        {
            _dbContext.BudgetReport.Add(environmentModel);
            await _dbContext.SaveChangesAsync();

            return null;// Ok();
        }
    }
}
