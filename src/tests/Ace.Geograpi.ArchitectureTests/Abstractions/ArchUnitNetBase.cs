using ArchUnitNET.Domain;
using ArchUnitNET.Fluent;
using ArchUnitNET.Fluent.Syntax.Elements.Types;
using ArchUnitNET.Fluent.Syntax.Elements.Types.Classes;
using ArchUnitNET.Loader;
using CatNip.Domain.Models.Interfaces;

namespace Ace.Geograpi.ArchitectureTests.Abstractions;

public abstract class ArchUnitNetBase : AbstractArchitectureTest
{
    protected static readonly Architecture architecture =
        new ArchLoader()
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

    protected static readonly GivenClassesConjunctionWithDescription domainModels =
        ArchRuleDefinition
            .Classes()
            .That().ImplementInterface(typeof(IModel))
            ////.Or().ImplementInterface(typeof(IModel<>))
            ////.Or().AreAssignableTo(typeof(TraceableModel<>))
            ////.Or().AreAssignableTo(typeof(TraceableModel<,>))
            .As("Domain models");
}
