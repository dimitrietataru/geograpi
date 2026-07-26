using CatNip.Domain.ImportExport.Csv;

namespace Ace.Geograpi.Domain.ImportExport.Dtos;

public sealed class ContinentExchangeDto : ICsvMappable
{
    public int RowNumber { get; set; }

    public string Name { get; set; } = default!;
}
