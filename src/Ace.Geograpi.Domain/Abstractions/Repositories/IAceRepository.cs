using Ace.Geograpi.Domain.Abstractions.Models.Interfaces;
using Ace.Geograpi.Domain.Abstractions.Query.Params;
using Ace.Geograpi.Domain.Abstractions.Repositories.Internal;

namespace Ace.Geograpi.Domain.Abstractions.Repositories;

public interface IAceRepository<TModel, TKey, TQueryParams>
    : IQueryRepository<TModel, TKey, TQueryParams>, ICrudRepository<TModel, TKey>
    where TModel : IModel<TKey>
    where TKey : IEquatable<TKey>
    where TQueryParams : IQueryParams
{
}
