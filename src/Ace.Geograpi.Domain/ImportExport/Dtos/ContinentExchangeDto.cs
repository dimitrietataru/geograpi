using CatNip.Domain.ImportExport.Csv;
using CatNip.Domain.ImportExport.Excel;

namespace Ace.Geograpi.Domain.ImportExport.Dtos;

public sealed class ContinentExchangeDto : ICsvMappable, IExcelMappable
{
    public int RowNumber { get; set; }

    public string Name { get; set; } = default!;
}
