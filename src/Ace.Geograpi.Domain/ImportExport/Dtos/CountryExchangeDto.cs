using CatNip.Domain.ImportExport.Csv;
using CatNip.Domain.ImportExport.Excel;

namespace Ace.Geograpi.Domain.ImportExport.Dtos;

[DebuggerDisplay("({RowNumber}. {Code}) {Name}")]
public sealed class CountryExchangeDto : ICsvMappable, IExcelMappable
{
    public int RowNumber { get; set; }

    public string ContinentCode { get; set; } = default!;

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
