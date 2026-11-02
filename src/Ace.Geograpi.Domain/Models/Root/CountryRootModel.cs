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

    public string GoogleId { get; set; } = default!;

    public decimal BoundaryN { get; set; }
    public decimal BoundaryS { get; set; }
    public decimal BoundaryE { get; set; }
    public decimal BoundaryW { get; set; }

    public decimal CenterLat { get; set; }
    public decimal CenterLng { get; set; }
}
