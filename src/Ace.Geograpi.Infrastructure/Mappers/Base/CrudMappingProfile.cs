using CatNip.Domain.Models;
using CatNip.Infrastructure.Data.Entities;

namespace Ace.Geograpi.Infrastructure.Mappers.Base;

public sealed class CrudMappingProfile : TwoWayProfile<CrudEntity<int>, CrudModel<int>>
{
    public override void ConfigureLeftToRightMapping()
    {
        CreateMap<CrudEntity<int>, CrudModel<int>>()
            .IgnoreAllPropertiesWithAnInaccessibleSetter()
            .IncludeAllDerived()
            .ForMember(
                model => model.Id,
                options => options.MapFrom(entity => entity.Id));
    }

    public override void ConfigureRightToLeftMapping()
    {
        CreateMap<CrudModel<int>, CrudEntity<int>>()
            .IgnoreAllPropertiesWithAnInaccessibleSetter()
            .IncludeAllDerived()
            .ForMember(
                entity => entity.Id,
                options => options.Ignore());
    }
}
