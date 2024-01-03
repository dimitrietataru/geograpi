using Ace.Geograpi.Domain.Abstractions.Models.Interfaces;

namespace Ace.Geograpi.Domain.Abstractions.Repositories.Internal;

public interface IQueryRepository<TModel, TKey>
    where TModel : IModel<TKey>
    where TKey : IEquatable<TKey>
{
    Task<IEnumerable<TModel>> GetAllAsync(CancellationToken cancellation = default);
    Task<int> CountAsync(CancellationToken cancellation = default);

    Task<TModel> GetByIdAsync(TKey id, CancellationToken cancellation = default);
    Task<bool> ExistsAsync(TKey id, CancellationToken cancellation = default);
}
