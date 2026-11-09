using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;

namespace Ace.Geograpi.ArchitectureTests.Layers.Infrastructure.Data.Entities;

public sealed class InfrastructureEntityNetArchTestTests : NetArchTestBase
{
    [Fact]
    internal void InfrastructureEntitiesShouldBeDefined()
    {
        // Arrange / Act
        var types = infrastructureDataEntities.GetTypes();

        // Assert
        types.Should().NotBeEmpty();
    }

    [Fact]
    internal void InfrastructureEntitiesShouldMatchNamespace()
    {
        // Arrange
        var rule = infrastructureDataEntities.Should().ResideInNamespaceMatching(NamespacePatterns.InfrastructureDataEntities);

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void InfrastructureEntitiesShouldHaveEntitySuffix()
    {
        // Arrange
        var rule = infrastructureDataEntities.Should().HaveNameEndingWith("Entity", StringComparison.Ordinal);

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void InfrastructureEntitiesShouldBePublic()
    {
        // Arrange
        var rule = infrastructureDataEntities.Should().BePublic();

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void InfrastructureEntitiesShouldBeSealed()
    {
        // Arrange
        var rule = infrastructureDataEntities.Should().BeSealed();

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }
}
