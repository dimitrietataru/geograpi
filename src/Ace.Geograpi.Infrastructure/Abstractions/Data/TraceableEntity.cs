using Ace.Geograpi.Infrastructure.Abstractions.Data.Interfaces;

namespace Ace.Geograpi.Infrastructure.Abstractions.Data;

public abstract class TraceableEntity<TKey> : Entity<TKey>, ITraceableEntity<TKey>
    where TKey : IEquatable<TKey>
{
    public virtual DateTimeOffset? CreatedAt { get; set; }
    public virtual DateTimeOffset? UpdatedAt { get; set; }
    public virtual DateTimeOffset? DeletedAt { get; set; }

    public virtual TKey? CreatedBy { get; set; }
    public virtual TKey? UpdatedBy { get; set; }
    public virtual TKey? DeletedBy { get; set; }

    public virtual bool IsDeleted { get; set; }
}

public abstract class TraceableEntity : Entity, ITraceable
{
    public virtual DateTimeOffset? CreatedAt { get; set; }
    public virtual DateTimeOffset? UpdatedAt { get; set; }
    public virtual DateTimeOffset? DeletedAt { get; set; }

    public virtual int CreatedBy { get; set; }
    public virtual int UpdatedBy { get; set; }
    public virtual int DeletedBy { get; set; }

    public virtual bool IsDeleted { get; set; }
}
