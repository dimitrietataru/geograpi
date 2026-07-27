using Ace.Geograpi.ArchitectureTests.Abstractions;
using ArchUnitNET.Domain;

namespace Ace.Geograpi.ArchitectureTests.Layers.Application;

public sealed class ApplicationLayerTests : ArchUnitNetBase
{
    private readonly IReadOnlyCollection<string?> allowedExceptions = [
        typeof(Geograpi.Application.IApplicationMarker).FullName,
        typeof(Geograpi.Application.DependencyInjection).FullName
    ];

    [Fact]
    internal void ApplicationTypesShouldBeCoveredByArchitectureRules()
    {
        // Arrange
        var typesWithNoRules = applicationTypes.GetObjects(architecture)
            .Except(applicationServices.GetObjects(architecture))
            .Except(applicationValidators.GetObjects(architecture))
            .Where(type => !allowedExceptions.Contains(type.FullName))
            .OfType<IType>()
            .ToList();

        // Assert
        typesWithNoRules.Should().BeEmpty(because: $"Application types should be covered by architecture rules: {string.Join(", ", typesWithNoRules.Select(t => t.FullName))}");
    }
}
