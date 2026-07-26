using CatNip.Application.Services;
using CatNip.Domain.Events;
using CatNip.Domain.ImportExport.Csv;
using CatNip.Domain.Models;
using CatNip.Domain.Models.Interfaces;
using CatNip.Domain.Query;
using CatNip.Domain.Query.Filtering;
using CatNip.Domain.Repositories;
using CatNip.Domain.Services;
using CatNip.Infrastructure.Data.Configurations;
using CatNip.Infrastructure.Data.Entities;
using CatNip.Infrastructure.Data.Entities.Interfaces;
using CatNip.Infrastructure.ImportExport.Mappings;
using CatNip.Infrastructure.Repositories;
using CatNip.Presentation.Controllers;
using NetArchTest.Rules;

namespace Ace.Geograpi.ArchitectureTests.Abstractions;

public abstract class NetArchTestBase : AbstractArchitectureTest
{
    protected static Types DomainTypes => Types.InAssembly(domainAssembly);
    protected static Types ApplicationTypes => Types.InAssembly(applicationAssembly);
    protected static Types InfrastructureTypes => Types.InAssembly(infrastructureAssembly);
    protected static Types WebTypes => Types.InAssembly(webAssembly);

    protected static readonly PredicateList domainEvents = DomainTypes
        .That().ImplementInterface(typeof(IEvent));

    protected static readonly PredicateList domainExchangeDtos = DomainTypes
        .That().ImplementInterface(typeof(ICsvMappable));

    protected static readonly PredicateList domainModels = DomainTypes
        .That().ImplementInterface(typeof(IModel))
        .Or().ImplementInterface(typeof(IModel<>))
        .Or().Inherit(typeof(TraceableModel<>))
        .Or().Inherit(typeof(TraceableModel<,>));

    protected static readonly PredicateList domainQueryFilters = DomainTypes
        .That().ImplementInterface(typeof(IFilteringRequest))
        .Or().Inherit(typeof(QueryFilter<>))
        .Or().Inherit(typeof(QueryFilter<,>));

    protected static readonly PredicateList domainRepositories = DomainTypes
        .That().ImplementInterface(typeof(ICrudRepository<>))
        .Or().ImplementInterface(typeof(ICrudRepository<,>))
        .Or().ImplementInterface(typeof(IAceRepository<,,,>));

    protected static readonly PredicateList domainServices = DomainTypes
        .That().ImplementInterface(typeof(ICrudService<>))
        .Or().ImplementInterface(typeof(ICrudService<,>))
        .Or().ImplementInterface(typeof(IAceService<,,,>));

    protected static readonly PredicateList applicationServices = ApplicationTypes
        .That().ImplementInterface(typeof(ICrudService<>))
        .Or().ImplementInterface(typeof(ICrudService<,>))
        .Or().ImplementInterface(typeof(IAceService<,,,>))
        .Or().Inherit(typeof(CrudService<,>))
        .Or().Inherit(typeof(CrudService<,,>))
        .Or().Inherit(typeof(AceService<,,,,>));

    protected static readonly PredicateList applicationValidators = ApplicationTypes
        .That().ImplementInterface(typeof(IValidator<>))
        .Or().Inherit(typeof(AbstractValidator<>));

    protected static readonly PredicateList infrastructureDataConfigurations = InfrastructureTypes
        .That().ImplementInterface(typeof(IEntityTypeConfiguration<>))
        .Or().Inherit(typeof(TraceableEntityConfiguration<,>))
        .Or().Inherit(typeof(TraceableEntityConfiguration<,,>))
        .Or().Inherit(typeof(EntityConfiguration<>))
        .Or().Inherit(typeof(EntityConfiguration<,>));

    protected static readonly PredicateList infrastructureDataEntities = InfrastructureTypes
        .That().ImplementInterface(typeof(IEntity))
        .Or().ImplementInterface(typeof(IEntity<>))
        .Or().ImplementInterface(typeof(ITraceableEntity<>))
        .Or().ImplementInterface(typeof(ITraceableEntity<,>))
        .Or().Inherit(typeof(Entity))
        .Or().Inherit(typeof(Entity<>))
        .Or().Inherit(typeof(TraceableEntity<>))
        .Or().Inherit(typeof(TraceableEntity<,>));

    protected static readonly PredicateList infrastructureCsvMaps = InfrastructureTypes
        .That().Inherit(typeof(ClassMap<>))
        .Or().Inherit(typeof(AceCsvMap<>));

    protected static readonly PredicateList infrastructureMappers = InfrastructureTypes
        .That().ImplementInterface(typeof(IOneWayProfile<,>))
        .Or().ImplementInterface(typeof(ITwoWayProfile<,>))
        .Or().Inherit(typeof(AbstractOneWayProfile<,>))
        .Or().Inherit(typeof(AbstractTwoWayProfile<,>))
        .Or().Inherit(typeof(Profile));

    protected static readonly PredicateList infrastructureRepositories = InfrastructureTypes
        .That().ImplementInterface(typeof(ICrudRepository<>))
        .Or().ImplementInterface(typeof(ICrudRepository<,>))
        .Or().ImplementInterface(typeof(IAceRepository<,,,>))
        .Or().Inherit(typeof(CrudRepository<,,>))
        .Or().Inherit(typeof(CrudRepository<,,,>))
        .Or().Inherit(typeof(AceRepository<,,,,,>));

    protected static readonly PredicateList webControllers = WebTypes
        .That().Inherit(typeof(CrudController<,>))
        .Or().Inherit(typeof(CrudController<,,>))
        .Or().Inherit(typeof(CrudController<,,,>))
        .Or().Inherit(typeof(AceController<,,,,>))
        .Or().Inherit(typeof(AceController<,,,,,>));
}
