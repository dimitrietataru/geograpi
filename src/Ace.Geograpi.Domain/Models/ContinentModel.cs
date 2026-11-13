using CatNip.Domain.Models;

namespace Ace.Geograpi.Domain.Models;

public sealed class ContinentModel : AceModel<int>
{
    /// <summary>
    /// Alpha-2
    /// </summary>
    /// <remarks>Example: <i>EU</i></remarks>
    public string Code { get; set; } = default!;

    /// <summary>
    /// Continent name (EN).
    /// </summary>
    /// <remarks>Example: <i>Europe</i></remarks>
    public string Name { get; set; } = default!;

    /// <summary>
    /// Google Place Id.
    /// </summary>
    public string GoogleId { get; set; } = default!;

    /// <summary>
    /// Northern Boundary (Latitude)
    /// </summary>
    public decimal BoundaryN { get; set; }

    /// <summary>
    /// Southern Boundary (Latitude)
    /// </summary>
    public decimal BoundaryS { get; set; }

    /// <summary>
    /// Eastern Boundary (Longiture)
    /// </summary>
    public decimal BoundaryE { get; set; }

    /// <summary>
    /// Western Boundary (Longiture)
    /// </summary>
    public decimal BoundaryW { get; set; }

    /// <summary>
    /// Center Point Latitude
    /// </summary>
    public decimal CenterLat { get; set; }

    /// <summary>
    /// Center Point Longitude
    /// </summary>
    public decimal CenterLng { get; set; }

    public IEnumerable<CountryModel> Countries { get; set; } = new HashSet<CountryModel>();
}
