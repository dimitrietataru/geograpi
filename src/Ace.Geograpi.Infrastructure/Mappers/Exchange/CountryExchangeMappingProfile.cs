using Ace.Geograpi.Domain.ImportExport.Dtos;
using Ace.Geograpi.Infrastructure.Data.Entities;

namespace Ace.Geograpi.Infrastructure.Mappers.Exchange;

public sealed class CountryExchangeMappingProfile : OneWayProfile<CountryExchangeDto, CountryEntity>
{
    public sealed override void ConfigureLeftToRightMapping()
    {
        CreateMap<CountryExchangeDto, CountryEntity>()
            .IgnoreAllPropertiesWithAnInaccessibleSetter()
            .ForMember(
                entity => entity.Id,
                options => options.Ignore())
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
