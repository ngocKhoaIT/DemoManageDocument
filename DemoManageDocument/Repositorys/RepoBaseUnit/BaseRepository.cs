using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DemoManageDocument.Repositorys.RepoBaseUnit
{
    public class BaseRepository<TModel> : IBaseRepository<TModel> where TModel : class
    {
        protected readonly DbContext Context;

        public BaseRepository(DbContext context)
        {
            Context = context;
        }
        public TModel Get(int id)
        {
            return Context.Set<TModel>().Find(id);
        }

        public IEnumerable<TModel> GetAll()
        {
            return Context.Set<TModel>().ToList();
        }
        public IEnumerable<TModel> Find(Expression<Func<TModel, bool>> predicate)
        {
            return Context.Set<TModel>().Where(predicate);
        }
        public void Add(TModel model)
        {
            Context.Set<TModel>().Add(model);
        }
        public void AddRange(IEnumerable<TModel> models)
        {
            Context.Set<TModel>().AddRange(models);
        }
        public void Update(TModel model)
        {
            Context.Set<TModel>().Update(model);
        }

        public void Remove(TModel model)
        {
            Context.Set<TModel>().Remove(model);
        }
        public void RemoveRange(IEnumerable<TModel> models)
        {
            Context.Set<TModel>().RemoveRange(models);
        }

    }
}
