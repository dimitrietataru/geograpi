using CatNip.Infrastructure.Data.Entities;

namespace Ace.Geograpi.Infrastructure.Data.Entities;

public sealed class CountryEntity : TraceableEntity<int>
{
    public int ContinentId { get; set; }

    public string Code { get; set; } = default!;
    public string CodeA3 { get; set; } = default!;

    public string Name { get; set; } = default!;
    public string NameOfficial { get; set; } = default!;

    public double Area { get; set; }
    public int Population { get; set; }

    public ContinentEntity Continent { get; set; } = default!;
}
