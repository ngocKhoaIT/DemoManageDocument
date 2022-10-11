using DemoManageDocument.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoManageDocument.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly DataDbContext _dbContext;
        public TestController(DataDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public IActionResult Add(Organization og)
        {
            var organizations = new Organization
            {
                OrganizationId = og.OrganizationId,
                OrganizationName = og.OrganizationName,
                OrganizationLevel = og.OrganizationLevel,
                amount = og.amount,
                personInCharge = og.personInCharge,
            };

            _dbContext.Organizations.Add(organizations);
            _dbContext.SaveChanges();
            
            return Ok("s");
        }
    }
}
