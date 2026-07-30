using Ace.Geograpi.Domain.ImportExport.Dtos;
using CatNip.Infrastructure.ImportExport.Mappings;

namespace Ace.Geograpi.Infrastructure.ImportExport.Mappings;

internal sealed class CountryExchangeExcelMap : AceExcelMap<CountryExchangeDto>
{
    internal static ContinentExchangeExcelMap Instance => new();

    public sealed override CountryExchangeDto Map(IXLRow row, IReadOnlyDictionary<string, int> headers)
    {
        return new()
        {
            RowNumber = row.RowNumber(),
            ContinentName = row.Cell(headers["Continent"]).GetString().Trim(),
            Name = row.Cell(headers["Name"]).GetString().Trim()
        };
    }
}
