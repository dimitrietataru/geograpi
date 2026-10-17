using CatNip.Domain.Models;

namespace Ace.Geograpi.Domain.Models;

public sealed class ContinentModel : TraceableModel<int>
{
    public string Code { get; set; } = default!;
    public string Name { get; set; } = default!;

    public IEnumerable<CountryModel> Countries { get; set; } = new HashSet<CountryModel>();
}
