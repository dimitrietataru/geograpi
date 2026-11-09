using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;
using ArchUnitNET.xUnitV3;

namespace Ace.Geograpi.ArchitectureTests.Layers.Infrastructure.Repositories;

public sealed class InfrastructureRepositoryArchUnitNetTests : ArchUnitNetBase
{
    [Fact]
    internal void InfrastructureRepositoriesShouldBeDefined()
    {
        // Arrange / Act
        var types = infrastructureRepositories.GetObjects(architecture);

        // Assert
        types.Should().NotBeEmpty();
    }

    [Fact]
    internal void InfrastructureRepositoriesShouldMatchNamespace()
    {
        // Arrange
        var rule = infrastructureRepositories.Should().ResideInNamespaceMatching(NamespacePatterns.InfrastructureRepositories);

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void InfrastructureRepositoriesShouldHaveRepositorySuffix()
    {
        // Arrange
        var rule = infrastructureRepositories.Should().HaveNameEndingWith("Repository");

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void InfrastructureRepositoriesShouldBeInternal()
    {
        // Arrange
        var rule = infrastructureRepositories.Should().BeInternal();

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void InfrastructureRepositoriesShouldBeSealed()
    {
        // Arrange
        var rule = infrastructureRepositories.Should().BeSealed();

        // Act / Assert
        rule.Check(architecture);
    }
}
