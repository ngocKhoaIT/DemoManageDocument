using DemoManageDocument.Models;
using DemoManageDocument.Repositorys.RepoBaseUnit;
using Microsoft.EntityFrameworkCore;

namespace DemoManageDocument.Repositorys
{
    public class OrganizationRepository : BaseRepository<Organization>, IOrganization
    {
        protected DataDbContext context;

        public OrganizationRepository(DataDbContext context) : base(context)
        {
            this.context = context;
        }

    }
}
