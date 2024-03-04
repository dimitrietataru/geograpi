using CatNip.Domain.Models;
using CatNip.Infrastructure.Data.Entities;

namespace Ace.Geograpi.Infrastructure.Mappers.Traceable;

internal sealed class TraceableIntMapper : TwoWayProfile<TraceableEntity<int>, TraceableModel<int>>
{
    public sealed override void ConfigureLeftToRightMapping()
    {
        CreateMap<TraceableEntity<int>, TraceableModel<int>>()
            .IgnoreAllPropertiesWithAnInaccessibleSetter()
            .IncludeAllDerived()
            .ForMember(
                model => model.CreatedAt,
                options => options.MapFrom(entity => entity.CreatedAt))
            .ForMember(
                model => model.CreatedBy,
                options => options.MapFrom(entity => entity.CreatedBy))
            .ForMember(
                model => model.UpdatedAt,
                options => options.MapFrom(entity => entity.UpdatedAt))
            .ForMember(
                model => model.UpdatedBy,
                options => options.MapFrom(entity => entity.UpdatedBy))
            .ForMember(
                model => model.IsDeleted,
                options => options.MapFrom(entity => entity.IsDeleted))
            .ForMember(
                model => model.DeletedAt,
                options => options.MapFrom(entity => entity.DeletedAt))
            .ForMember(
                model => model.DeletedBy,
                options => options.MapFrom(entity => entity.DeletedBy));
    }

    public sealed override void ConfigureRightToLeftMapping()
    {
        CreateMap<TraceableModel<int>, TraceableEntity<int>>()
            .IgnoreAllPropertiesWithAnInaccessibleSetter()
            .IncludeAllDerived()
            .ForMember(
                entity => entity.CreatedAt,
                options => options.Ignore())
            .ForMember(
                entity => entity.CreatedBy,
                options => options.Ignore())
            .ForMember(
                entity => entity.UpdatedAt,
                options => options.Ignore())
            .ForMember(
                entity => entity.UpdatedBy,
                options => options.Ignore())
            .ForMember(
                entity => entity.IsDeleted,
                options => options.Ignore())
            .ForMember(
                entity => entity.DeletedAt,
                options => options.Ignore())
            .ForMember(
                entity => entity.DeletedBy,
                options => options.Ignore());
    }
}
