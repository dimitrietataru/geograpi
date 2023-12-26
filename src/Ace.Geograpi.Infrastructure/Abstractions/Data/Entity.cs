using Ace.Geograpi.Infrastructure.Abstractions.Data.Interfaces;

namespace Ace.Geograpi.Infrastructure.Abstractions.Data;

public abstract class Entity<TKey> : Entity, IEntity<TKey>
    where TKey : IEquatable<TKey>
{
    public virtual TKey Id { get; set; } = default!;

    public override bool Equals(Entity? other)
    {
        if (other is not Entity<TKey> model)
        {
            return false;
        }

        if (Id.Equals(default) || model.Id.Equals(default))
        {
            return false;
        }

        return Id.Equals(model.Id);
    }

    private protected override int DetermineHashCode()
    {
        return HashCode.Combine(Id);
    }
}

public abstract class Entity : IEquatable<Entity>
{
    public override bool Equals(object? obj)
    {
        if (obj is not Entity other)
        {
            return false;
        }

        return Equals(other);
    }

    public override int GetHashCode()
    {
        return DetermineHashCode();
    }

    public abstract bool Equals(Entity? other);

    private protected abstract int DetermineHashCode();
}
