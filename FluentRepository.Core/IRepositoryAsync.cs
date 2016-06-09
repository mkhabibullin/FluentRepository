using FluentRepository.Core.Entity;
using System;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace FluentRepository.Core
{
    public interface IRepositoryAsync<TEntity> : IRepository<TEntity> where TEntity : IEntity
    {
        Task<TEntity> FindAsync(params object[] keyValues);
        Task<TEntity> FindAsync(CancellationToken cancellationToken, params object[] keyValues);

        Task<TEntity> SingleAsync(Expression<Func<TEntity, bool>> query);
        Task<TEntity> SingleAsync(CancellationToken cancellationToken, Expression<Func<TEntity, bool>> query);

        Task<bool> DeleteAsync(params object[] keyValues);
        Task<bool> DeleteAsync(CancellationToken cancellationToken, params object[] keyValues);
    }
}
