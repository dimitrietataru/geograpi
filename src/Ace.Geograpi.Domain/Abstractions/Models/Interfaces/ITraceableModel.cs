namespace Ace.Geograpi.Domain.Abstractions.Models.Interfaces;

public interface ITraceableModel
{
    DateTimeOffset? CreatedAt { get; set; }
    DateTimeOffset? UpdatedAt { get; set; }
    DateTimeOffset? DeletedAt { get; set; }

    int? CreatedBy { get; set; }
    int? UpdatedBy { get; set; }
    int? DeletedBy { get; set; }

    bool IsDeleted { get; set; }
}
