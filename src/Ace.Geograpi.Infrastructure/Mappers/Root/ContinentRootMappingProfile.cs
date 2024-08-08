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
                model => model.Name,
                options => options.MapFrom(entity => entity.Name));
    }
}
