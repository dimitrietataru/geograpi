using CatNip.Domain.ImportExport.Csv;
using CatNip.Domain.ImportExport.Excel;

namespace Ace.Geograpi.Domain.ImportExport.Dtos;

public sealed class CountryExchangeDto : ICsvMappable, IExcelMappable
{
    public int RowNumber { get; set; }

    public string ContinentName { get; set; } = default!;
    public string Name { get; set; } = default!;
}
