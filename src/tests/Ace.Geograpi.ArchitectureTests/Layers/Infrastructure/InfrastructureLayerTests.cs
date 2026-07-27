using Ace.Geograpi.ArchitectureTests.Abstractions;
using ArchUnitNET.Domain;

namespace Ace.Geograpi.ArchitectureTests.Layers.Infrastructure;

public sealed class InfrastructureLayerTests : ArchUnitNetBase
{
    private readonly IReadOnlyCollection<string?> allowedExceptions = [
        typeof(Geograpi.Infrastructure.IInfrastructureMarker).FullName,
        typeof(Geograpi.Infrastructure.DependencyInjection).FullName,
    ];

    ////[Fact] // TODO: Complete architecture tests for Infrastructure layer
    internal void InfrastructureTypesShouldBeCoveredByArchitectureRules()
    {
        // Arrange
        var typesWithNoRules = infrastructureTypes.GetObjects(architecture)
            .Except(infrastructureDataConfigurations.GetObjects(architecture))
            .Except(infrastructureDataEntities.GetObjects(architecture))
            .Except(infrastructureCsvMaps.GetObjects(architecture))
            .Except(infrastructureMappers.GetObjects(architecture))
            .Except(infrastructureRepositories.GetObjects(architecture))
            .Where(type => !allowedExceptions.Contains(type.FullName))
            .OfType<IType>()
            .ToList();

        // Assert
        typesWithNoRules.Should().BeEmpty(because: $"Infrastructure types should be covered by architecture rules: {string.Join(", ", typesWithNoRules.Select(t => t.FullName))}");
    }
}
