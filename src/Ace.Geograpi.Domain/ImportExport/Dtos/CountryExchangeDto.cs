using CatNip.Domain.ImportExport.Csv;

namespace Ace.Geograpi.Domain.ImportExport.Dtos;

public sealed class CountryExchangeDto : ICsvMappable
{
    public string ContinentName { get; set; } = default!;
    public string Name { get; set; } = default!;
}
