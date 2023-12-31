﻿using amazonppcapi.Models;
using amazonppcapi.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace amazonppcapi.Controllers
{

    [ApiController]
    [Route("api/BudgetReport")]
    public class BudgetReportController : ControllerBase
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
            return Ok(users);//Ok(users);
        }


        [HttpPost]
        public async Task<IActionResult> CreateProduct(BudgetReport environmentModel)
        {
            _dbContext.BudgetReport.Add(environmentModel);
            await _dbContext.SaveChangesAsync();

            return Ok();// Ok();
        }
    }
}
