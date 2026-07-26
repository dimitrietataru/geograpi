using Ace.Geograpi.Domain.ImportExport.Dtos;
using CatNip.Infrastructure.ImportExport.Mappings;

namespace Ace.Geograpi.Infrastructure.ImportExport.Mappings;

internal sealed class ContinentExchangeCsvMap : AceCsvMap<ContinentExchangeDto>
{
    public ContinentExchangeCsvMap()
        : base()
    {
        Map(dto => dto.Name).Name("Name");
    }
}
