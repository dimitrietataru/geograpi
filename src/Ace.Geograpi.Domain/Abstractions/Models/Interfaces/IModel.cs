namespace Ace.Geograpi.Domain.Abstractions.Models.Interfaces;

public interface IModel<TKey> : IModel
    where TKey : IEquatable<TKey>
{
    TKey Id { get; set; }
}

public interface IModel
{
}
