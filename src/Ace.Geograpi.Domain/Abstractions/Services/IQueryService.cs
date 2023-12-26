using Ace.Geograpi.Domain.Abstractions.Models.Interfaces;
using Ace.Geograpi.Domain.Abstractions.Query;
using Ace.Geograpi.Domain.Abstractions.Query.Interfaces;

namespace Ace.Geograpi.Domain.Abstractions.Services;

public interface IQueryService<TModel, TKey, TQueryParams> : IQueryService<TModel>
    where TModel : IModel<TKey>
    where TKey : IEquatable<TKey>
    where TQueryParams : IParams
{
    Task<IEnumerable<TModel>> GetAsync(Request<TQueryParams> request, CancellationToken cancellation);
    Task<IEnumerable<T>> GetAsync<T>(Request<TQueryParams> request, CancellationToken cancellation);

    Task<TModel> GetByIdAsync(TKey id, CancellationToken cancellation = default);
    Task<T> GetByIdAsync<T>(TKey id, CancellationToken cancellation = default);
}

public interface IQueryService<TModel>
{
    Task<IEnumerable<TModel>> GetAllAsync(CancellationToken cancellation = default);
    Task<IEnumerable<T>> GetAllAsync<T>(CancellationToken cancellation = default);
}
