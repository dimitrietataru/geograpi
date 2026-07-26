using Ace.Geograpi.Domain.ImportExport.Dtos;
using CsvHelper.Configuration;

namespace Ace.Geograpi.Infrastructure.ImportExport.Mappings;

internal sealed class ContinentExchangeCsvMap : ClassMap<ContinentExchangeDto>
{
    public ContinentExchangeCsvMap()
    {
        Map(dto => dto.Name).Name("Name");
    }
}
