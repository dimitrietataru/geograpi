using Ace.Geograpi.Infrastructure.Abstractions.Data;

namespace Ace.Geograpi.Infrastructure.Data.Entities;

internal sealed class Continent : TraceableEntity<int>
{
    public string Name { get; set; } = string.Empty;

    public IEnumerable<Country> Countries { get; set; } = new HashSet<Country>();
}
