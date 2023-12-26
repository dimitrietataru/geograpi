namespace Ace.Geograpi.Domain.Abstractions.Models.Interfaces;

public interface ITraceable : ITraceable<int>
{
}

public interface ITraceable<TTraceKey>
    where TTraceKey : IEquatable<TTraceKey>
{
    DateTimeOffset? CreatedAt { get; set; }
    DateTimeOffset? UpdatedAt { get; set; }
    DateTimeOffset? DeletedAt { get; set; }

    TTraceKey? CreatedBy { get; set; }
    TTraceKey? UpdatedBy { get; set; }
    TTraceKey? DeletedBy { get; set; }

    bool IsDeleted { get; set; }
}
