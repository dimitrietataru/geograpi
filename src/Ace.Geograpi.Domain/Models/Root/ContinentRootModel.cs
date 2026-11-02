using CatNip.Domain.Models;

namespace Ace.Geograpi.Domain.Models.Root;

public sealed class ContinentRootModel : Model<int>
{
    public string Code { get; set; } = default!;
    public string Name { get; set; } = default!;

    public string GoogleId { get; set; } = string.Empty;

    public decimal BoundaryN { get; set; }
    public decimal BoundaryS { get; set; }
    public decimal BoundaryE { get; set; }
    public decimal BoundaryW { get; set; }

    public decimal CenterLat { get; set; }
    public decimal CenterLng { get; set; }

    public int CountryCount { get; set; }
}
