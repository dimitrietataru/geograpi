using Ace.Geograpi.Domain.Abstractions.Query.Params;
using Ace.Geograpi.Domain.Abstractions.Symbols;

namespace Ace.Geograpi.Domain.Abstractions.Query;

#pragma warning disable IDE0290 // Use primary constructor
public sealed class QueryRequest<TQueryParams>
    where TQueryParams : IQueryParams
{
    public QueryRequest(TQueryParams queryParams)
    {
        QueryParams = queryParams;
    }

    public QueryRequest(TQueryParams queryParams, int? page, int? size)
        : this(queryParams)
    {
        QueryParams = queryParams;
        Page = page;
        Size = size;
    }

    public QueryRequest(TQueryParams queryParams, int? page, int? size, string? sortBy, SortDirection? sortDirection)
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
