using Ace.Geograpi.Domain.Abstractions.Models.Interfaces;

namespace Ace.Geograpi.Domain.Abstractions.Models;

public abstract class TraceableModel<TKey> : AbstractModel<TKey>, ITraceableModel<TKey>
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

public abstract class TraceableModel : AbstractModel, ITraceable
{
    public virtual DateTimeOffset? CreatedAt { get; set; }
    public virtual DateTimeOffset? UpdatedAt { get; set; }
    public virtual DateTimeOffset? DeletedAt { get; set; }

    public virtual int CreatedBy { get; set; }
    public virtual int UpdatedBy { get; set; }
    public virtual int DeletedBy { get; set; }

    public virtual bool IsDeleted { get; set; }
}
