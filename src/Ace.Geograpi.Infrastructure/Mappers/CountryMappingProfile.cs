using Ace.Geograpi.Domain.Models;
using Ace.Geograpi.Infrastructure.Data.Entities;

namespace Ace.Geograpi.Infrastructure.Mappers;

public sealed class CountryMappingProfile : TwoWayProfile<CountryEntity, CountryModel>
{
    public sealed override void ConfigureLeftToRightMapping()
    {
        CreateMap<CountryEntity, CountryModel>()
            .IgnoreAllPropertiesWithAnInaccessibleSetter()
            .ForMember(
                model => model.ContinentId,
                options => options.MapFrom(entity => entity.ContinentId))
            .ForMember(
                model => model.Code,
                options => options.MapFrom(entity => entity.Code))
            .ForMember(
                model => model.CodeA3,
                options => options.MapFrom(entity => entity.CodeA3))
            .ForMember(
                model => model.Name,
                options => options.MapFrom(entity => entity.Name))
            .ForMember(
                model => model.NameOfficial,
                options => options.MapFrom(entity => entity.NameOfficial))
            .ForMember(
                model => model.Area,
                options => options.MapFrom(entity => entity.Area))
            .ForMember(
                model => model.Population,
                options => options.MapFrom(entity => entity.Population))
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
                options => options.MapFrom(entity => entity.CenterLng));
    }

    public sealed override void ConfigureRightToLeftMapping()
    {
        CreateMap<CountryModel, CountryEntity>()
            .IgnoreAllPropertiesWithAnInaccessibleSetter()
            .ForMember(
                entity => entity.ContinentId,
                options => options.MapFrom(model => model.ContinentId))
            .ForMember(
                entity => entity.Code,
                options => options.MapFrom(model => model.Code))
            .ForMember(
                entity => entity.CodeA3,
                options => options.MapFrom(model => model.CodeA3))
            .ForMember(
                entity => entity.Name,
                options => options.MapFrom(model => model.Name))
            .ForMember(
                entity => entity.NameOfficial,
                options => options.MapFrom(model => model.NameOfficial))
            .ForMember(
                entity => entity.Area,
                options => options.MapFrom(model => model.Area))
            .ForMember(
                entity => entity.Population,
                options => options.MapFrom(model => model.Population))
            .ForMember(
                entity => entity.GoogleId,
                options => options.MapFrom(model => model.GoogleId))
            .ForMember(
                entity => entity.BoundaryN,
                options => options.MapFrom(model => model.BoundaryN))
            .ForMember(
                entity => entity.BoundaryS,
                options => options.MapFrom(model => model.BoundaryS))
            .ForMember(
                entity => entity.BoundaryE,
                options => options.MapFrom(model => model.BoundaryE))
            .ForMember(
                entity => entity.BoundaryW,
                options => options.MapFrom(model => model.BoundaryW))
            .ForMember(
                entity => entity.CenterLat,
                options => options.MapFrom(model => model.CenterLat))
            .ForMember(
                entity => entity.CenterLng,
                options => options.MapFrom(model => model.CenterLng))
            .ForMember(
                entity => entity.Continent,
                options => options.Ignore());
    }
}
