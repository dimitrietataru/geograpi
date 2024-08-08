using CatNip.Domain.Models;
using CatNip.Infrastructure.Data.Entities;

namespace Ace.Geograpi.Infrastructure.Mappers.Traceable;

public sealed class ModelIntMappingProfile : TwoWayProfile<Entity<int>, Model<int>>
{
    public override void ConfigureLeftToRightMapping()
    {
        CreateMap<Entity<int>, Model<int>>()
            .IgnoreAllPropertiesWithAnInaccessibleSetter()
            .IncludeAllDerived()
            .ForMember(
                model => model.Id,
                options => options.MapFrom(entity => entity.Id));
    }

    public override void ConfigureRightToLeftMapping()
    {
        CreateMap<Model<int>, Entity<int>>()
            .IgnoreAllPropertiesWithAnInaccessibleSetter()
            .IncludeAllDerived()
            .ForMember(
                entity => entity.Id,
                options => options.Ignore());
    }
}
