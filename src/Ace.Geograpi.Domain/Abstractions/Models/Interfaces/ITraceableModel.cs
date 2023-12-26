namespace Ace.Geograpi.Domain.Abstractions.Models.Interfaces;

public interface ITraceableModel<TKey> : ITraceableModel<TKey, TKey>
    where TKey : IEquatable<TKey>
{
}

public interface ITraceableModel<TModelKey, TTraceKey> : IModel<TModelKey>, ITraceable<TTraceKey>
    where TModelKey : IEquatable<TModelKey>
    where TTraceKey : IEquatable<TTraceKey>
{
}
