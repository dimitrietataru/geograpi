namespace Ace.Geograpi.Infrastructure.Abstractions.Data.Interfaces;

public interface IEntity<TKey>
    where TKey : IEquatable<TKey>
{
    TKey Id { get; set; }
}
