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
            Name = row.Cell(headers["Name"]).GetString().Trim()
        };
    }
}
