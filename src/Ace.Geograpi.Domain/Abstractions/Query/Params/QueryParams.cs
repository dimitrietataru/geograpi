namespace Ace.Geograpi.Domain.Abstractions.Query.Params;

public abstract class QueryParams<TIdentifier> : QueryParams<TIdentifier, TIdentifier>
    where TIdentifier : IEquatable<TIdentifier>
{
}

public abstract class QueryParams<TIdentifier, TCollectionIdentifier> : IQueryParams
    where TIdentifier : IEquatable<TIdentifier>
    where TCollectionIdentifier : IEquatable<TCollectionIdentifier>
{
    public virtual TIdentifier Id { get; set; } = default!;
    public virtual IEnumerable<TCollectionIdentifier> Ids { get; set; } = Enumerable.Empty<TCollectionIdentifier>();
}
