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
                entity => entity.Code,
                options => options.MapFrom(dto => dto.Code))
            .ForMember(
                entity => entity.Name,
                options => options.MapFrom(dto => dto.Name))
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
                options => options.MapFrom(model => model.CenterLng));
    }
}
