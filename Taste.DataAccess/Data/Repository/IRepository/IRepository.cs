using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Taste.DataAccess.Data.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        /* ----Basic Repository to do CRUD operations -----*/

        // Get a particular element
        T Get(int id);

        // Get all elements with specified query
        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null
            );

        // Get first or default element
        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null
            );

        // add an element
        void Add(T entity);

        // Remove the specified element
        void Remove(int id);

        // Remove the complete entity
        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entity);
    }
}