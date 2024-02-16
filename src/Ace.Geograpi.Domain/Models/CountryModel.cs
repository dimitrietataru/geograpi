using CatNip.Domain.Models;

namespace Ace.Geograpi.Domain.Models;

public sealed class CountryModel : TraceableModel<int>
{
    public int ContinentId { get; set; }

    public string Name { get; set; } = default!;
}
