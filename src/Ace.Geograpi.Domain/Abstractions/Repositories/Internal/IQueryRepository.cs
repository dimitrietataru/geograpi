using Ace.Geograpi.Domain.Abstractions.Models.Interfaces;
using Ace.Geograpi.Domain.Abstractions.Query;
using Ace.Geograpi.Domain.Abstractions.Query.Params;

namespace Ace.Geograpi.Domain.Abstractions.Repositories.Internal;

public interface IQueryRepository<TModel, TKey, TQueryParams>
    where TModel : IModel<TKey>
    where TKey : IEquatable<TKey>
    where TQueryParams : IQueryParams
{
    Task<QueryResponse<TModel>> GetAsync(QueryRequest<TQueryParams> request, CancellationToken cancellation = default);
    Task<int> CountAsync(QueryRequest<TQueryParams> request, CancellationToken cancellation = default);
}

public interface IQueryRepository<TModel, TKey> : IQueryRepository<TModel>
    where TModel : IModel<TKey>
    where TKey : IEquatable<TKey>
{
    Task<TModel> GetByIdAsync(TKey id, CancellationToken cancellation = default);
    Task<bool> ExistsAsync(TKey id, CancellationToken cancellation = default);
}

public interface IQueryRepository<TModel>
    where TModel : IModel
{
    Task<IEnumerable<TModel>> GetAllAsync(CancellationToken cancellation = default);
    Task<int> CountAsync(CancellationToken cancellation = default);
}
