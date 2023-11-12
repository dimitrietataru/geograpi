using Ace.Geograpi.Domain.Abstractions.Models.Interfaces;

namespace Ace.Geograpi.Domain.Abstractions.Models;

public abstract class TraceableModel<TKey> : AbstractModel<TKey>, ITraceableModel
    where TKey : IEquatable<TKey>
{
    public DateTimeOffset? CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }

    public int? CreatedBy { get; set; }
    public int? UpdatedBy { get; set; }
    public int? DeletedBy { get; set; }

    public bool IsDeleted { get; set; }
}

public abstract class TraceableModel : AbstractModel, ITraceableModel
{
    public DateTimeOffset? CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }

    public int? CreatedBy { get; set; }
    public int? UpdatedBy { get; set; }
    public int? DeletedBy { get; set; }

    public bool IsDeleted { get; set; }
}
