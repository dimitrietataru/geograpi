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
                model => model.Name,
                options => options.MapFrom(entity => entity.Name));
    }
}
