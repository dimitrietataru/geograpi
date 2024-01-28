using CatNip.Domain.Query;

namespace Ace.Geograpi.Domain.QueryFilters;

public sealed class CountryQueryFilter : QueryFilter<int>
{
    public string? Name { get; set; }
}
