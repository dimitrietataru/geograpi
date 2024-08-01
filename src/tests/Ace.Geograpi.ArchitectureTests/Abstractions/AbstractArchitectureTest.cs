using Ace.Geograpi.Application;
using Ace.Geograpi.Domain;
using Ace.Geograpi.Infrastructure;
using Ace.Geograpi.Web;

namespace Ace.Geograpi.ArchitectureTests.Abstractions;

public abstract class AbstractArchitectureTest
{
    protected static readonly Assembly domainAssembly = typeof(IDomainMarker).Assembly;
    protected static readonly Assembly applicationAssembly = typeof(IApplicationMarker).Assembly;
    protected static readonly Assembly infrastructureAssembly = typeof(IInfrastructureMarker).Assembly;
    protected static readonly Assembly webAssembly = typeof(IWebMarker).Assembly;
}
