using DemoManageDocument.Models;
using DemoManageDocument.Repositorys.RepoBaseUnit;
using Microsoft.EntityFrameworkCore;

namespace DemoManageDocument.Repositorys
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployee
    {
        protected DataDbContext context;

        public EmployeeRepository(DataDbContext context) : base(context)
        {
            this.context = context;
        }

    }
}
