using Ace.Geograpi.Domain.Abstractions.Models.Interfaces;

namespace Ace.Geograpi.Domain.Abstractions.Models;

public class AbstractModel<TKey> : AbstractModel, IModel<TKey>
    where TKey : IEquatable<TKey>
{
    public virtual TKey Id { get; set; } = default!;

    public override bool Equals(AbstractModel? other)
    {
        if (other is not AbstractModel<TKey> model)
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

public abstract class AbstractModel : IEquatable<AbstractModel>
{
    public override bool Equals(object? obj)
    {
        if (obj is not AbstractModel other)
        {
            return false;
        }

        return Equals(other);
    }

    public override int GetHashCode()
    {
        return DetermineHashCode();
    }

    public abstract bool Equals(AbstractModel? other);

    private protected abstract int DetermineHashCode();
}
