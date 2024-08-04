using CatNip.Application.Services;
using CatNip.Domain.Models;
using CatNip.Domain.Models.Interfaces;
using CatNip.Domain.Repositories;
using CatNip.Domain.Services;
using CatNip.Infrastructure.Data.Configurations;
using CatNip.Infrastructure.Data.Entities;
using CatNip.Infrastructure.Data.Entities.Interfaces;
using CatNip.Infrastructure.Repositories;
using CatNip.Presentation.Controllers;
using Microsoft.EntityFrameworkCore;
using NetArchTest.Rules;

namespace Ace.Geograpi.ArchitectureTests.Abstractions;

public abstract class NetArchTestBase : AbstractArchitectureTest
{
    protected static readonly Types domainTypes = Types.InAssembly(domainAssembly);
    protected static readonly Types applicationTypes = Types.InAssembly(applicationAssembly);
    protected static readonly Types infrastructureTypes = Types.InAssembly(infrastructureAssembly);
    protected static readonly Types webTypes = Types.InAssembly(webAssembly);

    protected static readonly PredicateList domainModels = domainTypes
        .That().ImplementInterface(typeof(IModel))
        .Or().ImplementInterface(typeof(IModel<>))
        .Or().Inherit(typeof(TraceableModel<>))
        .Or().Inherit(typeof(TraceableModel<,>));

    protected static readonly PredicateList applicationServices = applicationTypes
        .That().ImplementInterface(typeof(ICrudService<>))
        .Or().ImplementInterface(typeof(ICrudService<,>))
        .Or().ImplementInterface(typeof(IAceService<,,>))
        .Or().Inherit(typeof(CrudService<,>))
        .Or().Inherit(typeof(CrudService<,,>))
        .Or().Inherit(typeof(AceService<,,,>));

    protected static readonly PredicateList infrastructureDataConfigurations = infrastructureTypes
        .That().ImplementInterface(typeof(IEntityTypeConfiguration<>))
        .Or().Inherit(typeof(TraceableEntityConfiguration<,>))
        .Or().Inherit(typeof(TraceableEntityConfiguration<,,>))
        .Or().Inherit(typeof(EntityConfiguration<>))
        .Or().Inherit(typeof(EntityConfiguration<,>));

    protected static readonly PredicateList infrastructureDataEntities = infrastructureTypes
        .That().ImplementInterface(typeof(IEntity))
        .Or().ImplementInterface(typeof(IEntity<>))
        .Or().ImplementInterface(typeof(ITraceableEntity<>))
        .Or().ImplementInterface(typeof(ITraceableEntity<,>))
        .Or().Inherit(typeof(Entity))
        .Or().Inherit(typeof(Entity<>))
        .Or().Inherit(typeof(TraceableEntity<>))
        .Or().Inherit(typeof(TraceableEntity<,>));

    protected static readonly PredicateList infrastructureRepositories = infrastructureTypes
        .That().ImplementInterface(typeof(ICrudRepository<>))
        .Or().ImplementInterface(typeof(ICrudRepository<,>))
        .Or().ImplementInterface(typeof(IAceRepository<,,>))
        .Or().Inherit(typeof(CrudRepository<,,>))
        .Or().Inherit(typeof(CrudRepository<,,,>))
        .Or().Inherit(typeof(AceRepository<,,,,>));

    protected static readonly PredicateList webControllers = webTypes
        .That().Inherit(typeof(CrudController<,>))
        .Or().Inherit(typeof(CrudController<,,>))
        .Or().Inherit(typeof(AceController<,,,>));
}
