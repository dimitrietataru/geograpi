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
            GoogleId = row.Cell(headers["Google Id"]).GetString().Trim(),
            BoundaryN = row.Cell(headers["BoundaryN"]).GetValue<decimal>(),
            BoundaryS = row.Cell(headers["BoundaryS"]).GetValue<decimal>(),
            BoundaryE = row.Cell(headers["BoundaryE"]).GetValue<decimal>(),
            BoundaryW = row.Cell(headers["BoundaryW"]).GetValue<decimal>(),
            CenterLat = row.Cell(headers["CenterLat"]).GetValue<decimal>(),
            CenterLng = row.Cell(headers["CenterLng"]).GetValue<decimal>()
        };
    }
}
