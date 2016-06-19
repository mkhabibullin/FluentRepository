using FluentRepository.Core.Entity;
using System.Threading;
using System.Threading.Tasks;

namespace FluentRepository.Core.UnitOfWork
{
    public interface IUnitOfWorkAsync : IUnitOfWork
    {
        Task<int> SaveChangesAsync();

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
