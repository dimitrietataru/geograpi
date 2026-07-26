using Ace.Geograpi.Domain.ImportExport.Dtos;
using CatNip.Infrastructure.ImportExport.Mappings;
using CsvHelper.Configuration;

namespace Ace.Geograpi.Infrastructure.ImportExport.Mappings;

internal sealed class CountryExchangeCsvMap : AceCsvMap<CountryExchangeDto>
{
    public CountryExchangeCsvMap()
        : base()
    {
        Map(c => c.ContinentName).Name("Continent");
        Map(c => c.Name).Name("Name");
    }
}
