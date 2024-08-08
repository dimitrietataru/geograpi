using CatNip.Domain.Models;

namespace Ace.Geograpi.Domain.Models.Root;

public sealed class CountryRootModel : Model<int>
{
    public int ContinentId { get; set; }
    public string Name { get; set; } = default!;
}
