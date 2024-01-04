namespace Ace.Geograpi.Domain.Abstractions.Query.Pagination;

public interface IPaginationRequest
{
    int? Page { get; }
    int? Size { get; }
}
