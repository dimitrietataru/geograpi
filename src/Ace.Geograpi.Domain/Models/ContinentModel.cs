using CatNip.Domain.Models;

namespace Ace.Geograpi.Domain.Models;

public sealed class ContinentModel : TraceableModel<int>
{
    public string Name { get; set; } = string.Empty;

    public IEnumerable<CountryModel> Countries { get; set; } = new HashSet<CountryModel>();
}
