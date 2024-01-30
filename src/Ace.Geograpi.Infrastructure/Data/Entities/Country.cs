using CatNip.Infrastructure.Data.Entities;

namespace Ace.Geograpi.Infrastructure.Data.Entities;

internal sealed class Country : TraceableEntity<int>
{
    public int ContinentId { get; set; }

    public string Name { get; set; } = default!;

    public Continent Continent { get; set; } = default!;
}
