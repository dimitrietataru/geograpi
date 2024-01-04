using Ace.Geograpi.Domain.Abstractions.Models.Interfaces;

namespace Ace.Geograpi.Domain.Abstractions.Repositories.Internal;

public interface ICommandRepository<TModel, TKey> : ICommandRepository<TModel>
    where TModel : IModel<TKey>
    where TKey : IEquatable<TKey>
{
    Task DeleteAsync(TKey id, CancellationToken cancellation = default);
}

public interface ICommandRepository<TModel>
    where TModel : IModel
{
    Task<TModel> CreateAsync(TModel model, CancellationToken cancellation = default);
    Task UpdateAsync(TModel model, CancellationToken cancellation = default);
}
