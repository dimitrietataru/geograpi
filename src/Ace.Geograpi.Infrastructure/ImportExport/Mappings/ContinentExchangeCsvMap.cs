using Ace.Geograpi.Domain.ImportExport.Dtos;
using CatNip.Infrastructure.ImportExport.Mappings;

namespace Ace.Geograpi.Infrastructure.ImportExport.Mappings;

internal sealed class ContinentExchangeCsvMap : AceCsvMap<ContinentExchangeDto>
{
    public ContinentExchangeCsvMap()
        : base()
    {
        Map(dto => dto.Code).Name("Code");
        Map(dto => dto.Name).Name("Name");

        Map(c => c.GoogleId).Name("Google Id");
        Map(c => c.BoundaryN).Name("BoundaryN");
        Map(c => c.BoundaryS).Name("BoundaryS");
        Map(c => c.BoundaryE).Name("BoundaryE");
        Map(c => c.BoundaryW).Name("BoundaryW");
        Map(c => c.CenterLat).Name("CenterLat");
        Map(c => c.CenterLng).Name("CenterLng");
    }
}
