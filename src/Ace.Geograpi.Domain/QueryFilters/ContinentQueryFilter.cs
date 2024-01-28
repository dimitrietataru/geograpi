using CatNip.Domain.Query;

namespace Ace.Geograpi.Domain.QueryFilters;

public sealed class ContinentQueryFilter : QueryFilter<int>
{
    public string? Name { get; set; }
}
