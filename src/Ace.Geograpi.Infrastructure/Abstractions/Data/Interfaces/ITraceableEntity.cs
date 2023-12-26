namespace Ace.Geograpi.Infrastructure.Abstractions.Data.Interfaces;

public interface ITraceableEntity<TKey> : ITraceableEntity<TKey, TKey>
    where TKey : IEquatable<TKey>
{
}

public interface ITraceableEntity<TEntityKey, TTraceKey> : IEntity<TEntityKey>, ITraceable<TTraceKey>
    where TEntityKey : IEquatable<TEntityKey>
    where TTraceKey : IEquatable<TTraceKey>
{
}
