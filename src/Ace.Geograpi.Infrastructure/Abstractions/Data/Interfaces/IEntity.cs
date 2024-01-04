namespace Ace.Geograpi.Infrastructure.Abstractions.Data.Interfaces;

public interface IEntity<TKey> : IEntity
    where TKey : IEquatable<TKey>
{
    TKey Id { get; set; }
}

public interface IEntity
{
}
