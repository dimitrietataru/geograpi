using Ace.Geograpi.Domain.Abstractions.Models.Interfaces;
using Ace.Geograpi.Domain.Abstractions.Query;
using Ace.Geograpi.Domain.Abstractions.Query.Params;

namespace Ace.Geograpi.Domain.Abstractions.Services;

#pragma warning disable CA1005 // Avoid excessive parameters on generic types
public interface IQueryService<TModel, TKey, TQueryParams> : IQueryService<TModel>
    where TModel : IModel<TKey>
    where TKey : IEquatable<TKey>
    where TQueryParams : IQueryParams
{
    Task<QueryResponse<TModel>> GetAsync(QueryRequest<TQueryParams> request, CancellationToken cancellation);
    Task<TModel> GetByIdAsync(TKey id, CancellationToken cancellation = default);
}

public interface IQueryService<TModel>
{
    Task<IEnumerable<TModel>> GetAllAsync(CancellationToken cancellation = default);
}
