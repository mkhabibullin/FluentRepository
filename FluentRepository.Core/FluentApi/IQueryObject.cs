using FluentRepository.Core.Entity;
using System;
using System.Linq.Expressions;

namespace FluentRepository.Core.FluentApi
{
    public interface IQueryObject<TEntity> where TEntity : IEntity
    {
        Expression<Func<TEntity, bool>> Query();
        Expression<Func<TEntity, bool>> And(Expression<Func<TEntity, bool>> query);
        Expression<Func<TEntity, bool>> Or(Expression<Func<TEntity, bool>> query);
        Expression<Func<TEntity, bool>> And(IQueryObject<TEntity> queryObject);
        Expression<Func<TEntity, bool>> Or(IQueryObject<TEntity> queryObject);
    }
}
