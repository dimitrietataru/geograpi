using Ace.Geograpi.ArchitectureTests.Abstractions;
using ArchUnitNET.Domain;

namespace Ace.Geograpi.ArchitectureTests.Layers.Domain;

public sealed class DomainLayerTests : ArchUnitNetBase
{
    private readonly IReadOnlyCollection<string?> allowedExceptions = [
        typeof(Geograpi.Domain.IDomainMarker).FullName,
        typeof(Geograpi.Domain.Symbols.Constraints).FullName,
        typeof(Geograpi.Domain.Symbols.Data.ContinentId).FullName,
        typeof(Geograpi.Domain.Symbols.Data.ContinentName).FullName,
        typeof(Geograpi.Domain.Symbols.Data.CountryId).FullName,
        typeof(Geograpi.Domain.Symbols.Data.CountryName).FullName
    ];

    [Fact]
    internal void DomainTypesShouldBeCoveredByArchitectureRules()
    {
        // Arrange
        var typesWithNoRules = domainTypes.GetObjects(architecture)
            .Except(domainEvents.GetObjects(architecture))
            .Except(domainExchangeDtos.GetObjects(architecture))
            .Except(domainModels.GetObjects(architecture))
            .Except(domainQueryFilters.GetObjects(architecture))
            .Except(domainRepositories.GetObjects(architecture))
            .Except(domainServices.GetObjects(architecture))
            .Where(type => !allowedExceptions.Contains(type.FullName))
            .OfType<IType>()
            .ToList();

        // Assert
        typesWithNoRules.Should().BeEmpty(because: $"Domain types should be covered by architecture rules: {string.Join(", ", typesWithNoRules.Select(t => t.FullName))}");
    }
}
