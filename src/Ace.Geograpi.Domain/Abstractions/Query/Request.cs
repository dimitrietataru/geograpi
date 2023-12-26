using Ace.Geograpi.Domain.Abstractions.Query.Interfaces;
using Ace.Geograpi.Domain.Abstractions.Symbols;

namespace Ace.Geograpi.Domain.Abstractions.Query;

public sealed class Request<TQueryParams>
    where TQueryParams : IParams
{
    public Request(TQueryParams queryParams)
    {
        QueryParams = queryParams;
    }

    public Request(TQueryParams queryParams, int? page, int? size)
        : this(queryParams)
    {
        QueryParams = queryParams;
        Page = page;
        Size = size;
    }

    public Request(TQueryParams queryParams, int? page, int? size, string? sortBy, SortDirection? sortDirection)
        : this(queryParams, page, size)
    {
        SortBy = sortBy;
        SortDirection = sortDirection;
    }

    public int? Page { get; init; }
    public int? Size { get; init; }

    public string? SortBy { get; init; }
    public SortDirection? SortDirection { get; init; }

    public TQueryParams QueryParams { get; init; }
}
