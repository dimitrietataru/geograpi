using CatNip.Domain.Models;

namespace Ace.Geograpi.Domain.Models.Root;

public sealed class CountryRootModel : Model<int>
{
    public int ContinentId { get; set; }

    public string Code { get; set; } = default!;
    public string CodeA3 { get; set; } = default!;

    public string Name { get; set; } = default!;
    public string NameOfficial { get; set; } = default!;

    public double Area { get; set; }
    public int Population { get; set; }
}
