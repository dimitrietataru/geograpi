namespace Ace.Geograpi.Domain.Abstractions.Query;

public sealed class QueryResponse<TModel>
{
    public QueryResponse()
    {
    }

    public QueryResponse(int? page, int? size, int count, IEnumerable<TModel> items)
        : this()
    {
        Page = page;
        Size = size;
        Count = count;
        Items = items;
    }

    public int? Page { get; init; }
    public int? Size { get; init; }
    public int Count { get; init; }
    public IEnumerable<TModel> Items { get; init; } = new List<TModel>();
}
