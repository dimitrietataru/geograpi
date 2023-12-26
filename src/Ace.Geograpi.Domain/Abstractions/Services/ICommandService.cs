using Ace.Geograpi.Domain.Abstractions.Models.Interfaces;

namespace Ace.Geograpi.Domain.Abstractions.Services;

public interface ICommandService<TModel, TKey> : ICommandService<TModel>
    where TModel : IModel<TKey>
    where TKey : IEquatable<TKey>
{
    Task<bool> ExistsAsync(TKey id, CancellationToken cancellation = default);

    Task UpdateAsync(TKey id, TModel model, CancellationToken cancellation = default);

    void Delete(TKey id);
    Task DeleteAsync(TKey id, CancellationToken cancellation = default);
}

public interface ICommandService<TModel>
{
    void Create(TModel model);
    Task<TModel> CreateAsync(TModel model, CancellationToken cancellation = default);

    void Update(TModel model);
    Task<TModel> UpdateAsync(TModel model, CancellationToken cancellation = default);

    void Delete(TModel model);
    Task<TModel> DeleteAsync(TModel model, CancellationToken cancellation = default);
}
