using ArchUnitNET.Domain;
using ArchUnitNET.Fluent;
using ArchUnitNET.Fluent.Syntax.Elements.Types;
using ArchUnitNET.Fluent.Syntax.Elements.Types.Classes;
using ArchUnitNET.Fluent.Syntax.Elements.Types.Interfaces;
using ArchUnitNET.Loader;
using CatNip.Domain.Events;
using CatNip.Domain.ImportExport.Csv;
using CatNip.Domain.Models.Interfaces;
using CatNip.Domain.Query.Filtering;
using CatNip.Domain.Repositories;
using CatNip.Domain.Services;
using CatNip.Infrastructure.Data.Entities.Interfaces;
using CatNip.Infrastructure.ImportExport.Mappings;
using CatNip.Presentation.Controllers;

namespace Ace.Geograpi.ArchitectureTests.Abstractions;

public abstract class ArchUnitNetBase : AbstractArchitectureTest
{
    protected static readonly Architecture architecture = new ArchLoader()
        .LoadAssemblies(
            domainAssembly,
            applicationAssembly,
            infrastructureAssembly,
            webAssembly)
        .Build();

    protected static readonly IObjectProvider<IType> domainLayer =
        ArchRuleDefinition.Types().That().ResideInAssembly(domainAssembly).As("Domain");
    protected static readonly GivenTypesConjunctionWithDescription domainTypes =
        ArchRuleDefinition.Types().That().Are(domainLayer).As("Domain types");

    protected static readonly IObjectProvider<IType> applicationLayer =
        ArchRuleDefinition.Types().That().ResideInAssembly(applicationAssembly).As("Application");
    protected static readonly GivenTypesConjunctionWithDescription applicationTypes =
        ArchRuleDefinition.Types().That().Are(applicationLayer).As("Application types");

    protected static readonly IObjectProvider<IType> infrastructureLayer =
        ArchRuleDefinition.Types().That().ResideInAssembly(infrastructureAssembly).As("Infrastructure");
    protected static readonly GivenTypesConjunctionWithDescription infrastructureTypes =
        ArchRuleDefinition.Types().That().Are(infrastructureLayer).As("Infrastructure types");

    protected static readonly IObjectProvider<IType> webLayer =
        ArchRuleDefinition.Types().That().ResideInAssembly(webAssembly).As("Web");
    protected static readonly GivenTypesConjunctionWithDescription webTypes =
        ArchRuleDefinition.Types().That().Are(webLayer).As("Web types");

    protected static readonly GivenClassesConjunctionWithDescription domainEvents =
        ArchRuleDefinition
            .Classes()
            .That().ResideInAssembly(domainAssembly)
            .And().ImplementInterface(typeof(IEvent))
            .As("Domain events");

    protected static readonly GivenClassesConjunctionWithDescription domainExchangeDtos =
        ArchRuleDefinition
            .Classes()
            .That().ResideInAssembly(domainAssembly)
            .And().ImplementInterface(typeof(ICsvMappable))
            .As("Domain exchange DTOs");

    protected static readonly GivenClassesConjunctionWithDescription domainModels =
        ArchRuleDefinition
            .Classes()
            .That().ResideInAssembly(domainAssembly)
            .And().ImplementInterface(typeof(IModel))
            ////.Or().ImplementInterface(typeof(IModel<>))
            ////.Or().AreAssignableTo(typeof(TraceableModel<>))
            ////.Or().AreAssignableTo(typeof(TraceableModel<,>))
            .As("Domain models");

    protected static readonly GivenClassesConjunctionWithDescription domainQueryFilters =
        ArchRuleDefinition
            .Classes()
            .That().ResideInAssembly(domainAssembly)
            .And().ImplementInterface(typeof(IFilteringRequest))
            ////.Or().AreAssignableTo(typeof(QueryFilter<>))
            ////.Or().AreAssignableTo(typeof(QueryFilter<,>))
            .As("Domain query filters");

    protected static readonly GivenInterfacesConjunction domainRepositories =
        ArchRuleDefinition
            .Interfaces()
            .That().ResideInAssembly(domainAssembly)
            ////.And().ImplementInterface(typeof(ICrudRepository<>))
            .And().ImplementInterface(typeof(ICrudRepository<,>))
            ////.And().ImplementInterface(typeof(IAceRepository<,,>))
            .As("Domain repositories");

    protected static readonly GivenInterfacesConjunction domainServices =
        ArchRuleDefinition
            .Interfaces()
            .That().ResideInAssembly(domainAssembly)
            ////.And().ImplementInterface(typeof(ICrudService<>))
            .And().ImplementInterface(typeof(ICrudService<,>))
            ////.And().ImplementInterface(typeof(IAceService<,,>))
            .As("Domain services");

    protected static readonly GivenClassesConjunctionWithDescription applicationServices =
        ArchRuleDefinition
            .Classes()
            .That().ResideInAssembly(applicationAssembly)
            .And().ImplementInterface(typeof(ICrudService<>))
            ////.Or().ImplementInterface(typeof(ICrudService<,>))
            .Or().ImplementInterface(typeof(IAceService<,,,>))
            ////.Or().AreAssignableTo(typeof(CrudService<,>))
            ////.Or().AreAssignableTo(typeof(CrudService<,,>))
            ////.Or().AreAssignableTo(typeof(AceService<,,,,>))
            .As("Application services");

    protected static readonly GivenClassesConjunctionWithDescription applicationValidators =
        ArchRuleDefinition
            .Classes()
            .That().ResideInAssembly(applicationAssembly)
            .And().ImplementInterface(typeof(IValidator<>))
            ////.Or().AreAssignableTo(typeof(AbstractValidator<>))
            .As("Application validators");

    protected static readonly GivenClassesConjunctionWithDescription infrastructureDataConfigurations =
        ArchRuleDefinition
            .Classes()
            .That().ResideInAssembly(infrastructureAssembly)
            .And().ImplementInterface(typeof(IEntityTypeConfiguration<>))
            ////.Or().AreAssignableTo(typeof(TraceableEntityConfiguration<,>))
            ////.Or().AreAssignableTo(typeof(TraceableEntityConfiguration<,,>))
            ////.Or().AreAssignableTo(typeof(EntityConfiguration<>))
            ////.Or().AreAssignableTo(typeof(EntityConfiguration<,>))
            .As("Infrastructure data configurations");

    protected static readonly GivenClassesConjunctionWithDescription infrastructureDataEntities =
        ArchRuleDefinition
            .Classes()
            .That().ResideInAssembly(infrastructureAssembly)
            .And().ImplementInterface(typeof(IEntity))
            ////.Or().ImplementInterface(typeof(IEntity<>))
            ////.Or().ImplementInterface(typeof(ITraceableEntity<>))
            ////.Or().ImplementInterface(typeof(ITraceableEntity<,>))
            ////.Or().AreAssignableTo(typeof(Entity))
            ////.Or().AreAssignableTo(typeof(Entity<>))
            ////.Or().AreAssignableTo(typeof(TraceableEntity<>))
            ////.Or().AreAssignableTo(typeof(TraceableEntity<,>))
            .As("Infrastructure data entities");

    protected static readonly GivenClassesConjunctionWithDescription infrastructureCsvMaps =
        ArchRuleDefinition
            .Classes()
            .That().ResideInAssembly(infrastructureAssembly)
            .And().AreAssignableTo(typeof(ClassMap<>))
            .Or().AreAssignableTo(typeof(AceCsvMap<>))
            .As("Infrastructure CSV mappings");

    protected static readonly GivenClassesConjunctionWithDescription infrastructureMappers =
        ArchRuleDefinition
            .Classes()
            .That().ResideInAssembly(infrastructureAssembly)
            .And().ImplementInterface(typeof(IOneWayProfile<,>))
            .Or().ImplementInterface(typeof(ITwoWayProfile<,>))
            ////.Or().AreAssignableTo(typeof(AbstractOneWayProfile<,>))
            ////.Or().AreAssignableTo(typeof(AbstractTwoWayProfile<,>))
            .Or().AreAssignableTo(typeof(Profile))
            .As("Infrastructure mappers");

    protected static readonly GivenClassesConjunctionWithDescription infrastructureConsumers =
        ArchRuleDefinition
            .Classes()
            .That().ResideInAssembly(infrastructureAssembly)
            .And().ImplementInterface(typeof(IConsumer))
            .Or().ImplementInterface(typeof(IConsumer<>))
            .As("Infrastructure consumers");

    protected static readonly GivenClassesConjunctionWithDescription infrastructureConsumerDefinitions =
        ArchRuleDefinition
            .Classes()
            .That().ResideInAssembly(infrastructureAssembly)
            .And().ImplementInterface(typeof(IConsumerDefinition))
            .Or().ImplementInterface(typeof(IConsumerDefinition<>))
            .Or().AreAssignableTo(typeof(ConsumerDefinition<>))
            .As("Infrastructure consumer definitions");

    protected static readonly GivenClassesConjunctionWithDescription infrastructureRepositories =
        ArchRuleDefinition
            .Classes()
            .That().ResideInAssembly(infrastructureAssembly)
            .And().ImplementInterface(typeof(ICrudRepository<>))
            ////.Or().ImplementInterface(typeof(ICrudRepository<,>))
            .Or().ImplementInterface(typeof(IAceRepository<,,,>))
            ////.Or().AreAssignableTo(typeof(CrudRepository<,,>))
            ////.Or().AreAssignableTo(typeof(CrudRepository<,,,>))
            ////.Or().AreAssignableTo(typeof(AceRepository<,,,,,>))
            .As("Infrastructure repositories");

    protected static readonly GivenClassesConjunctionWithDescription webControllers =
        ArchRuleDefinition
            .Classes()
            .That().ResideInAssembly(webAssembly)
            ////.And().AreAssignableTo(typeof(CrudController<,>))
            ////.And().AreAssignableTo(typeof(CrudController<,,>))
            ////.And().AreAssignableTo(typeof(CrudController<,,,>))
            ////.And().AreAssignableTo(typeof(AceController<,,,,>))
            .And().AreAssignableTo(typeof(AceController<,,,,,>))
            .As("Web controllers");
}
