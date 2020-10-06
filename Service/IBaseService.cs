using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Service
{
    public interface IBaseService<TEntity>
    {
        long Count();

        TEntity GetSingle(string id);
        TEntity GetSingleBy(Expression<Func<TEntity, bool>> predicate);

        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAllBy(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void DeleteBy(Expression<Func<TEntity, bool>> predicate);
    }
}
