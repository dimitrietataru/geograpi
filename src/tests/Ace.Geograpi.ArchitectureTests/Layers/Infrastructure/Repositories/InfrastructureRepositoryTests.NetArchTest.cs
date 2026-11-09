using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;

namespace Ace.Geograpi.ArchitectureTests.Layers.Infrastructure.Repositories;

public sealed class InfrastructureRepositoryNetArchTestTests : NetArchTestBase
{
    [Fact]
    internal void InfrastructureRepositoriesShouldBeDefined()
    {
        // Arrange / Act
        var types = infrastructureRepositories.GetTypes();

        // Assert
        types.Should().NotBeEmpty();
    }

    [Fact]
    internal void InfrastructureRepositoriesShouldMatchNamespace()
    {
        // Arrange
        var rule = infrastructureRepositories.Should().ResideInNamespaceMatching(NamespacePatterns.InfrastructureRepositories);

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void InfrastructureRepositoriesShouldHaveRepositorySuffix()
    {
        // Arrange
        var rule = infrastructureRepositories.Should().HaveNameEndingWith("Repository", StringComparison.Ordinal);

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void InfrastructureRepositoriesShouldBeInternal()
    {
        // Arrange
        var rule = infrastructureRepositories.Should().NotBePublic();

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void InfrastructureRepositoriesShouldBeSealed()
    {
        // Arrange
        var rule = infrastructureRepositories.Should().BeSealed();

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }
}
