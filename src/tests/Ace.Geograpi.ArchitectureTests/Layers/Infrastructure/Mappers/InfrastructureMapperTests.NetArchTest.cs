using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;

namespace Ace.Geograpi.ArchitectureTests.Layers.Infrastructure.Mappers;

public sealed class InfrastructureMapperNetArchTestTests : NetArchTestBase
{
    [Fact]
    internal void InfrastructureMappersShouldBeDefined()
    {
        // Arrange / Act
        var types = infrastructureMappers.GetTypes();

        // Assert
        types.Should().NotBeEmpty();
    }

    [Fact]
    internal void InfrastructureMappersShouldMatchNamespace()
    {
        // Arrange
        var rule = infrastructureMappers.Should().ResideInNamespaceMatching(NamespacePatterns.InfrastructureMappers);

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void InfrastructureMappersShouldHaveMappingProfileSuffix()
    {
        // Arrange
        var rule = infrastructureMappers.Should().HaveNameEndingWith("MappingProfile", StringComparison.Ordinal);

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void InfrastructureMappersShouldBePublic()
    {
        // Arrange
        var rule = infrastructureMappers.Should().BePublic();

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void InfrastructureMappersShouldBeSealed()
    {
        // Arrange
        var rule = infrastructureMappers.Should().BeSealed();

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }
}
