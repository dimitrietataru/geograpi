using CatNip.Domain.Models;

namespace Ace.Geograpi.Domain.Models;

public sealed class CountryModel : TraceableModel<int>
{
    public int ContinentId { get; set; }

    /// <summary>
    /// ISO 3166-1 Alpha-2.
    /// </summary>
    /// <remarks>Example: <i>NO</i></remarks>
    public string Code { get; set; } = default!;

    /// <summary>
    /// ISO 3166-1 Alpha-3.
    /// </summary>
    /// <remarks>Example: <i>NOR</i></remarks>
    public string CodeA3 { get; set; } = default!;

    /// <summary>
    /// Country name.
    /// </summary>
    /// <remarks>Example: <i>Norway</i></remarks>
    public string Name { get; set; } = default!;

    /// <summary>
    /// Country official name.
    /// </summary>
    /// <remarks>Example: <i>Kingdom of Norway</i></remarks>
    public string NameOfficial { get; set; } = default!;

    /// <summary>
    /// Country area.
    /// </summary>
    /// <remarks>Example: <i>12345678.99</i></remarks>
    public double Area { get; set; }

    /// <summary>
    /// Country population.
    /// </summary>
    public int Population { get; set; }
}
