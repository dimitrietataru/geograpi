using Ace.Geograpi.Domain.Abstractions.Query.Interfaces;

namespace Ace.Geograpi.Domain.Abstractions.Query.Params;

public abstract class ModelParams<TIdentifier> : ModelParams<TIdentifier, TIdentifier>
    where TIdentifier : IEquatable<TIdentifier>
{
}

public abstract class ModelParams<TIdentifier, TCollectionIdentifier> : IParams
    where TIdentifier : IEquatable<TIdentifier>
    where TCollectionIdentifier : IEquatable<TCollectionIdentifier>
{
    public virtual TIdentifier Id { get; set; } = default!;
    public virtual IEnumerable<TCollectionIdentifier> Ids { get; set; } = Enumerable.Empty<TCollectionIdentifier>();
}
