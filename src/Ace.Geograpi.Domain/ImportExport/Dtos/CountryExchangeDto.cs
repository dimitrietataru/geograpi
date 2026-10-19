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
}
