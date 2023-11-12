namespace Ace.Geograpi.Domain.Abstractions.Models.Interfaces;

public interface IModel<TKey>
    where TKey : IEquatable<TKey>
{
    TKey Id { get; set; }
}
