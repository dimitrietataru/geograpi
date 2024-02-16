using CatNip.Infrastructure.Data.Entities;

namespace Ace.Geograpi.Infrastructure.Data.Entities;

public sealed class CountryEntity : TraceableEntity<int>
{
    public int ContinentId { get; set; }

    public string Name { get; set; } = default!;

    public ContinentEntity Continent { get; set; } = default!;
}
