using ContinentEntity = Ace.Geograpi.Infrastructure.Data.Entities.Continent;
using ContinentModel = Ace.Geograpi.Domain.Models.Continent;

namespace Ace.Geograpi.Infrastructure.Mappers;

public sealed class ContinentMappingProfile : TwoWayProfile<ContinentEntity, ContinentModel>
{
    public sealed override void ConfigureLeftToRightMapping()
    {
        CreateMap<ContinentEntity, ContinentModel>()
            .IgnoreAllPropertiesWithAnInaccessibleSetter()
            .IncludeAllDerived()
            .ForMember(
                model => model.Id,
                options => options.MapFrom(entity => entity.Id))
            .ForMember(
                model => model.Name,
                options => options.MapFrom(entity => entity.Name))
            .ForMember(
                model => model.Countries,
                options => options.MapFrom(entity => entity.Countries));
    }

    public sealed override void ConfigureRightToLeftMapping()
    {
        CreateMap<ContinentModel, ContinentEntity>()
            .IgnoreAllPropertiesWithAnInaccessibleSetter()
            .IncludeAllDerived()
            .ForMember(
                entity => entity.Id,
                options => options.Ignore())
            .ForMember(
                entity => entity.Name,
                options => options.MapFrom(model => model.Name))
            .ForMember(
                entity => entity.Countries,
                options => options.MapFrom(model => model.Countries));
    }
}