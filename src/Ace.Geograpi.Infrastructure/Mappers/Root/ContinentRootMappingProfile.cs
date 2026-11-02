using Ace.Geograpi.Domain.Models.Root;
using Ace.Geograpi.Infrastructure.Data.Entities;

namespace Ace.Geograpi.Infrastructure.Mappers.Root;

public sealed class ContinentRootMappingProfile : OneWayProfile<ContinentEntity, ContinentRootModel>
{
    public sealed override void ConfigureLeftToRightMapping()
    {
        CreateMap<ContinentEntity, ContinentRootModel>()
            .IgnoreAllPropertiesWithAnInaccessibleSetter()
            .ForMember(
                model => model.Code,
                options => options.MapFrom(entity => entity.Code))
            .ForMember(
                model => model.Name,
                options => options.MapFrom(entity => entity.Name))
            .ForMember(
                model => model.GoogleId,
                options => options.MapFrom(entity => entity.GoogleId))
            .ForMember(
                model => model.BoundaryN,
                options => options.MapFrom(entity => entity.BoundaryN))
            .ForMember(
                model => model.BoundaryS,
                options => options.MapFrom(entity => entity.BoundaryS))
            .ForMember(
                model => model.BoundaryE,
                options => options.MapFrom(entity => entity.BoundaryE))
            .ForMember(
                model => model.BoundaryW,
                options => options.MapFrom(entity => entity.BoundaryW))
            .ForMember(
                model => model.CenterLat,
                options => options.MapFrom(entity => entity.CenterLat))
            .ForMember(
                model => model.CenterLng,
                options => options.MapFrom(entity => entity.CenterLng))
            .ForMember(
                model => model.CountryCount,
                options => options.MapFrom(entity => entity.Countries.Count()));
    }
}
