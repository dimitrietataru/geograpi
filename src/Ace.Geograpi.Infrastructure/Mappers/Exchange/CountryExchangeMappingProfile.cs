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
                entity => entity.Name,
                options => options.MapFrom(dto => dto.Name));
    }
}
