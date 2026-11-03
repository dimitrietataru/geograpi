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

        Map(c => c.GoogleId).Name("Google Id");
        Map(c => c.BoundaryN).Name("BoundaryN");
        Map(c => c.BoundaryS).Name("BoundaryS");
        Map(c => c.BoundaryE).Name("BoundaryE");
        Map(c => c.BoundaryW).Name("BoundaryW");
        Map(c => c.CenterLat).Name("CenterLat");
        Map(c => c.CenterLng).Name("CenterLng");
    }
}
