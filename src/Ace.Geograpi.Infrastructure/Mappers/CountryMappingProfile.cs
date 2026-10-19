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
                options => options.MapFrom(entity => entity.Population));
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
                entity => entity.Continent,
                options => options.Ignore());
    }
}
