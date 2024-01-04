using Ace.Geograpi.Domain.Abstractions.Query.Pagination;
using Ace.Geograpi.Domain.Abstractions.Query.Params;
using Ace.Geograpi.Domain.Abstractions.Query.Sorting;
using Ace.Geograpi.Domain.Abstractions.Symbols;

namespace Ace.Geograpi.Domain.Abstractions.Query;

#pragma warning disable IDE0290 // Use primary constructor
public sealed class QueryRequest<TQueryParams> : QueryRequest
    where TQueryParams : IQueryParams
{
    public QueryRequest(TQueryParams queryParams)
    {
        QueryParams = queryParams;
    }

    public QueryRequest(TQueryParams queryParams, int? page, int? size)
        : this(queryParams)
    {
        Page = page;
        Size = size;
    }

    public QueryRequest(TQueryParams queryParams, int? page, int? size, string? sortBy, SortDirection? sortDirection)
        : this(queryParams, page, size)
    {
        SortBy = sortBy;
        SortDirection = sortDirection;
    }

    public TQueryParams QueryParams { get; init; }
}

public abstract class QueryRequest : IPaginationRequest, ISortingRequest
{
    public virtual int? Page { get; init; }
    public virtual int? Size { get; init; }

    public virtual string? SortBy { get; init; }
    public virtual SortDirection? SortDirection { get; init; }
}
