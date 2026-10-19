using Ace.Geograpi.Domain.ImportExport.Dtos;
using CatNip.Infrastructure.ImportExport.Mappings;

namespace Ace.Geograpi.Infrastructure.ImportExport.Mappings;

internal sealed class CountryExchangeCsvMap : AceCsvMap<CountryExchangeDto>
{
    public CountryExchangeCsvMap()
        : base()
    {
        Map(c => c.ContinentCode).Name("Continent");

        Map(c => c.Code).Name("CodeA2");
        Map(c => c.CodeA3).Name("CodeA3");

        Map(c => c.Name).Name("Name");
        Map(c => c.NameOfficial).Name("Official Name");

        Map(c => c.Area).Name("Area");
        Map(c => c.Population).Name("Population");
    }
}
