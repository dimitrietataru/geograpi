using Ace.Geograpi.Domain.Abstractions.Models;

namespace Ace.Geograpi.Domain.Models;

public sealed class Continent : AbstractModel<int>
{
    public string Name { get; set; } = string.Empty;

    public IEnumerable<Country> Countries { get; set; } = new HashSet<Country>();
}
