using CatNip.Infrastructure.Data.Entities;

namespace Ace.Geograpi.Infrastructure.Data.Entities;

public sealed class ContinentEntity : TraceableEntity<int>
{
    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;

    public string GoogleId { get; set; } = string.Empty;

    public decimal BoundaryN { get; set; }
    public decimal BoundaryS { get; set; }
    public decimal BoundaryE { get; set; }
    public decimal BoundaryW { get; set; }

    public decimal CenterLat { get; set; }
    public decimal CenterLng { get; set; }

    public IEnumerable<CountryEntity> Countries { get; set; } = new HashSet<CountryEntity>();
}
