using CatNip.Domain.Query;

namespace Ace.Geograpi.Domain.QueryFilters;

public sealed class CountryQueryFilter : QueryFilter<int>
{
    public string? Code { get; set; }
    public string? Name { get; set; }
    public ICollection<int> ContinentIds { get; set; } = [];
}
