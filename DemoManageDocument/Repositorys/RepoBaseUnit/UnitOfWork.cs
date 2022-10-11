using DemoManageDocument.Models;

namespace DemoManageDocument.Repositorys.RepoBaseUnit
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataDbContext _context;
        public UnitOfWork(DataDbContext context)
        {
            _context = context;
            Organizations = new OrganizationRepository(_context);
            Departments = new DepartmentRepository(_context);
            Employees = new EmployeeRepository(_context);
        }

        public IOrganization Organizations { get; private set; }
        public IDepartment Departments { get; private set; }
        public IEmployee Employees { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
