using Ace.Geograpi.Domain.ImportExport.Dtos;
using CatNip.Infrastructure.ImportExport.Mappings;

namespace Ace.Geograpi.Infrastructure.ImportExport.Mappings;

internal sealed class ContinentExchangeExcelMap : AceExcelMap<ContinentExchangeDto>
{
    internal static ContinentExchangeExcelMap Instance => new();

    public sealed override ContinentExchangeDto Map(IXLRow row, IReadOnlyDictionary<string, int> headers)
    {
        return new()
        {
            RowNumber = row.RowNumber(),
            Code = row.Cell(headers["Code"]).GetString().Trim(),
            Name = row.Cell(headers["Name"]).GetString().Trim(),
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
