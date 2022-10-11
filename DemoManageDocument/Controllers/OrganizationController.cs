using DemoManageDocument.Models;
using DemoManageDocument.Repositorys.RepoBaseUnit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoManageDocument.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationController : ControllerBase
    {
        private readonly IUnitOfWork _unit;

        public OrganizationController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpGet]
        [Route("{id}")]
        public Organization Get(int id)
        {
            return _unit.Organizations.Get(id);
        }

        [HttpGet]
        public IEnumerable<Organization> GetAll()
        {
            return _unit.Organizations.GetAll();
        }

        [HttpPost]
        public JsonResult AddOrganization(Organization og)
        {
            var organizations = new Organization
            {
                OrganizationId = og.OrganizationId,
                OrganizationName = og.OrganizationName,
                OrganizationLevel = og.OrganizationLevel,
                amount = og.amount,
                personInCharge = og.personInCharge,
            };
            _unit.Organizations.Add(organizations);
            _unit.Complete();
            return new JsonResult("Added Successfully");
        }

        [HttpPut]
        public JsonResult UpdateOrganization(Organization og)
        {
            _unit.Organizations.Update(og);
            _unit.Complete();
            return new JsonResult("Updated Successfully");
        }

        [HttpDelete]
        public JsonResult RemoveOrganization(Organization og)
        {
            _unit.Organizations.Remove(og);
            _unit.Complete();
            return new JsonResult("Removed Successfully");
        }
    }
}
