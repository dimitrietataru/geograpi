using Ace.Geograpi.Domain.ImportExport.Dtos;
using CatNip.Infrastructure.ImportExport.Mappings;

namespace Ace.Geograpi.Infrastructure.ImportExport.Mappings;

internal sealed class CountryExchangeExcelMap : AceExcelMap<CountryExchangeDto>
{
    internal static CountryExchangeExcelMap Instance => new();

    public sealed override CountryExchangeDto Map(IXLRow row, IReadOnlyDictionary<string, int> headers)
    {
        return new()
        {
            RowNumber = row.RowNumber(),
            ContinentCode = row.Cell(headers["Continent"]).GetString().Trim(),
            Code = row.Cell(headers["CodeA2"]).GetString().Trim(),
            CodeA3 = row.Cell(headers["CodeA3"]).GetString().Trim(),
            Name = row.Cell(headers["Name"]).GetString().Trim(),
            NameOfficial = row.Cell(headers["Official Name"]).GetString().Trim(),
            Area = row.Cell(headers["Area"]).GetValue<double>(),
            Population = row.Cell(headers["Population"]).GetValue<int>(),
        };
    }
}
