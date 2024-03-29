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
                model => model.Id,
                options => options.MapFrom(entity => entity.Id))
            .ForMember(
                model => model.ContinentId,
                options => options.MapFrom(entity => entity.ContinentId))
            .ForMember(
                model => model.Name,
                options => options.MapFrom(entity => entity.Name));
    }

    public sealed override void ConfigureRightToLeftMapping()
    {
        CreateMap<CountryModel, CountryEntity>()
            .IgnoreAllPropertiesWithAnInaccessibleSetter()
            .ForMember(
                entity => entity.Id,
                options => options.Ignore())
            .ForMember(
                entity => entity.ContinentId,
                options => options.MapFrom(model => model.ContinentId))
            .ForMember(
                entity => entity.Name,
                options => options.MapFrom(model => model.Name))
            .ForMember(
                entity => entity.Continent,
                options => options.Ignore());
    }
}
