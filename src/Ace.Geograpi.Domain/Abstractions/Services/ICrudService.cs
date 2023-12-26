using Ace.Geograpi.Domain.Abstractions.Models.Interfaces;
using Ace.Geograpi.Domain.Abstractions.Query.Interfaces;

namespace Ace.Geograpi.Domain.Abstractions.Services;

public interface ICrudService<TModel, TKey, TQueryParams>
    : IQueryService<TModel, TKey, TQueryParams>, ICommandService<TModel, TKey>
    where TModel : IModel<TKey>
    where TKey : IEquatable<TKey>
    where TQueryParams : IParams
{
}

public interface ICrudService<TModel> : IQueryService<TModel>, ICommandService<TModel>
{
}
