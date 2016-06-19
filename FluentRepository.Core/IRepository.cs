using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using FluentRepository.Core.Entity;
using FluentRepository.Core.FluentApi;

namespace FluentRepository.Core
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        TEntity Find(params object[] keyValues);

        TEntity Single(Expression<Func<TEntity, bool>> query);

        IQueryable<TEntity> Queryable();

        IQueryable<TEntity> SelectQuery(string query, params object[] parameters);

        void Insert(TEntity entity);

        void InsertRange(IEnumerable<TEntity> entities);

        void Update(TEntity entity);

        void Delete(object id);
        void Delete(TEntity entity);

        #region Fluent interface

        IQueryFluent<TEntity> Query(IQueryObject<TEntity> queryObject);
        IQueryFluent<TEntity> Query(Expression<Func<TEntity, bool>> query);
        IQueryFluent<TEntity> Query();

        #endregion
    }
}
