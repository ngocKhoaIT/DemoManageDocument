namespace DemoManageDocument.Repositorys.RepoBaseUnit
{
    public interface IUnitOfWork : IDisposable
    {
        IOrganization Organizations { get; }
        IDepartment Departments { get; }
        IEmployee Employees { get; }
        int Complete();
    }
}
