using Ace.Geograpi.Domain.ImportExport.Dtos;
using Ace.Geograpi.Infrastructure.Data.Entities;

namespace Ace.Geograpi.Infrastructure.Mappers.Exchange;

public sealed class ContinentExchangeMappingProfile : OneWayProfile<ContinentExchangeDto, ContinentEntity>
{
    public sealed override void ConfigureLeftToRightMapping()
    {
        CreateMap<ContinentExchangeDto, ContinentEntity>()
            .IgnoreAllPropertiesWithAnInaccessibleSetter()
            .ForMember(
                entity => entity.Id,
                options => options.Ignore())
            .ForMember(
                entity => entity.Name,
                options => options.MapFrom(dto => dto.Name));
    }
}
