using Ace.Geograpi.Domain.ImportExport.Dtos;
using CsvHelper.Configuration;

namespace Ace.Geograpi.Infrastructure.ImportExport.Mappings;

internal sealed class CountryExchangeCsvMap : ClassMap<CountryExchangeDto>
{
    public CountryExchangeCsvMap()
    {
        Map(c => c.ContinentName).Name("Continent");
        Map(c => c.Name).Name("Name");
    }
}
