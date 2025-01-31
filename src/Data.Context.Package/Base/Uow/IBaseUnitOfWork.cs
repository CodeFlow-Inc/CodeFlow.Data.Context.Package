using System.Threading;
using System.Threading.Tasks;

namespace CodeFlow.Data.Context.Package.Base.Uow;

public interface IBaseUnitOfWork
{
    Task BeginTransactionAsync(CancellationToken cancellationToken = default);
    Task<int> CommitAsync(CancellationToken cancellationToken = default);
    void Dispose();
    Task RollbackAsync();
}