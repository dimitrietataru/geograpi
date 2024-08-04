using CatNip.Application.Services;
using CatNip.Domain.Models;
using CatNip.Domain.Models.Interfaces;
using CatNip.Domain.Services;
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
}
