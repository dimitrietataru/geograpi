using Ace.Geograpi.Domain.Abstractions.Exceptions;
using Ace.Geograpi.Infrastructure.Abstractions.Data.Interfaces;

namespace Ace.Geograpi.Infrastructure.Abstractions.Exceptions;

public class EntityNotFoundException<TEntity, TKey> : NotFoundException
    where TEntity : IEntity<TKey>
    where TKey : IEquatable<TKey>
{
    public EntityNotFoundException()
    {
    }

    public EntityNotFoundException(string message)
        : base(message)
    {
    }

    public EntityNotFoundException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public EntityNotFoundException(TKey id)
        : base($"Entity {typeof(TEntity).Name} {{ id: {id}}} not found.")
    {
    }

    public EntityNotFoundException(TKey id, string message)
        : base($"Entity {typeof(TEntity).Name} {{ id: {id}}} not found. {message}")
    {
    }

    public EntityNotFoundException(TKey id, string message, Exception innerException)
        : base($"Entity {typeof(TEntity).Name} {{ id: {id}}} not found. {message}", innerException)
    {
    }
}
