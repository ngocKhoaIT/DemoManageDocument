using DemoManageDocument.Models;
using DemoManageDocument.Repositorys.RepoBaseUnit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoManageDocument.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IUnitOfWork _unit;
        public DepartmentController(IUnitOfWork unitOfWork)
        {
            _unit = unitOfWork;
        }

        [HttpGet]
        [Route("{id}")]
        public Department Get(int id)
        {
            return _unit.Departments.Get(id);
        }

        [HttpGet]
        public IEnumerable<Department> GetAll()
        {
            return _unit.Departments.GetAll();
        }

        [HttpPost]
        public JsonResult Add(Department og)
        {
            var Departments = new Department
            {
                DepartmentId = og.DepartmentId,
                DepartmentName = og.DepartmentName,
                Organization = og.Organization,
            };
            _unit.Departments.Add(Departments);
            _unit.Complete();
            return new JsonResult("Added Successfully");
        }

        [HttpPut]
        public JsonResult Update(Department og)
        {
            _unit.Departments.Update(og);
            _unit.Complete();
            return new JsonResult("Updated Successfully");
        }

        [HttpDelete]
        public JsonResult Remove(Department og)
        {
            _unit.Departments.Remove(og);
            _unit.Complete();
            return new JsonResult("Removed Successfully");
        }
    }
}
