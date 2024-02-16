using CatNip.Infrastructure.Data.Entities;

namespace Ace.Geograpi.Infrastructure.Data.Entities;

public sealed class ContinentEntity : TraceableEntity<int>
{
    public string Name { get; set; } = string.Empty;

    public IEnumerable<CountryEntity> Countries { get; set; } = new HashSet<CountryEntity>();
}
