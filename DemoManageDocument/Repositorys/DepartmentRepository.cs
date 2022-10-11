using DemoManageDocument.Models;
using DemoManageDocument.Repositorys.RepoBaseUnit;
using Microsoft.EntityFrameworkCore;

namespace DemoManageDocument.Repositorys
{
    public class DepartmentRepository : BaseRepository<Department>, IDepartment
    {
        protected DataDbContext context;

        public DepartmentRepository(DataDbContext context) : base(context)
        {
            this.context = context;
        }

    }
}
