using Ace.Geograpi.Domain.Abstractions.Symbols;

namespace Ace.Geograpi.Domain.Abstractions.Query.Sorting;

public interface ISortingRequest
{
    string? SortBy { get; }
    SortDirection? SortDirection { get; }
}
