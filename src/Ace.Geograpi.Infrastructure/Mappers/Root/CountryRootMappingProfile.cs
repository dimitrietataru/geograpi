using Ace.Geograpi.Domain.Models.Root;
using Ace.Geograpi.Infrastructure.Data.Entities;

namespace Ace.Geograpi.Infrastructure.Mappers.Root;

public sealed class CountryRootMappingProfile : OneWayProfile<CountryEntity, CountryRootModel>
{
    public sealed override void ConfigureLeftToRightMapping()
    {
        CreateMap<CountryEntity, CountryRootModel>()
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
}
