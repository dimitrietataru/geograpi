using Ace.Geograpi.Domain.Abstractions.Models.Interfaces;

namespace Ace.Geograpi.Domain.Abstractions.Services;

public interface ICommandService<TModel, TKey> : ICommandService<TModel>
    where TModel : IModel<TKey>
    where TKey : IEquatable<TKey>
{
    Task UpdateAsync(TKey id, TModel model, CancellationToken cancellation = default);
    Task DeleteAsync(TKey id, CancellationToken cancellation = default);
}

public interface ICommandService<TModel>
{
    Task<TModel> CreateAsync(TModel model, CancellationToken cancellation = default);
    Task UpdateAsync(TModel model, CancellationToken cancellation = default);
    Task DeleteAsync(TModel model, CancellationToken cancellation = default);
}
