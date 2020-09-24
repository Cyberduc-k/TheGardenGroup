using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Model;

namespace DAL
{
    public interface IBaseRepository<TEntity> where TEntity: class, IEntityBase, new()
    {
        // get all items
        IEnumerable<TEntity> GetAll();

        // get the number of items
        long Count();

        // get a single item by id
        TEntity GetSingle(string id);

        // get a single item by condition
        TEntity GetSingleBy(Expression<Func<TEntity, bool>> predicate);

        // get all items by condition
        IEnumerable<TEntity> GetAllBy(Expression<Func<TEntity, bool>> predicate);

        // add an item
        void Add(TEntity entity);

        // update an item
        void Update(TEntity entity);

        // remove an item
        void Delete(TEntity entity);

        // remove an item by condition
        void DeleteBy(Expression<Func<TEntity, bool>> predicate);
    }
}
