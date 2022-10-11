﻿using System.Linq.Expressions;

namespace DemoManageDocument.Repositorys.RepoBaseUnit
{
    public interface IBaseRepository<TModel> where TModel : class
    {
        TModel Get(int id);
        IEnumerable<TModel> GetAll();
        IEnumerable<TModel> Find(Expression<Func<TModel, bool>> predicate);
        void Add(TModel model);
        void AddRange(IEnumerable<TModel> models);
        void Update(TModel model);
        void Remove(TModel model);
        void RemoveRange(IEnumerable<TModel> models);
    }
}
