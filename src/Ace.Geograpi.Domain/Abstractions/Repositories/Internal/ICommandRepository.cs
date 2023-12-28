using Ace.Geograpi.Domain.Abstractions.Models.Interfaces;

namespace Ace.Geograpi.Domain.Abstractions.Repositories.Internal;

public interface ICommandRepository<TModel, TKey>
    where TModel : IModel<TKey>
    where TKey : IEquatable<TKey>
{
    Task<TModel> CreateAsync(TModel model, CancellationToken cancellation = default);
    Task UpdateAsync(TModel model, CancellationToken cancellation = default);
    Task DeleteAsync(TKey id, CancellationToken cancellation = default);
}
