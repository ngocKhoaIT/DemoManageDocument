using DemoManageDocument.Models;
using DemoManageDocument.Repositorys.RepoBaseUnit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoManageDocument.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IUnitOfWork _unit;
        public EmployeeController(IUnitOfWork unitOfWork)
        {
            _unit = unitOfWork;
        }

        [HttpGet]
        [Route("{id}")]
        public Employee Get(int id)
        {
            return _unit.Employees.Get(id);
        }

        [HttpGet]
        public IEnumerable<Employee> GetAll()
        {
            return _unit.Employees.GetAll();
        }

        [HttpPost]
        public JsonResult Add(Employee og)
        {
            var Employees = new Employee
            {
                EmployeeId = og.EmployeeId,
                EmployeeName = og.EmployeeName,
                position = og.position,
                Department = og.Department,
                Email = og.Email,
                PhoneNumber = og.PhoneNumber,
                Sex = og.Sex,
            };
            _unit.Employees.Add(Employees);
            _unit.Complete();
            return new JsonResult("Added Successfully");
        }

        [HttpPut]
        public JsonResult Update(Employee og)
        {
            _unit.Employees.Update(og);
            _unit.Complete();
            return new JsonResult("Updated Successfully");
        }

        [HttpDelete]
        public JsonResult Remove(Employee og)
        {
            _unit.Employees.Remove(og);
            _unit.Complete();
            return new JsonResult("Removed Successfully");
        }
    }
}
