using Ace.Geograpi.Domain.Abstractions.Models.Interfaces;
using Ace.Geograpi.Domain.Abstractions.Repositories.Internal;

namespace Ace.Geograpi.Domain.Abstractions.Repositories;

public interface ICrudRepository<TModel, TKey>
    : IQueryRepository<TModel, TKey>, ICommandRepository<TModel, TKey>
    where TModel : IModel<TKey>
    where TKey : IEquatable<TKey>
{
}
