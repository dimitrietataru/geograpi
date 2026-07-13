using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;
using ArchUnitNET.xUnit;

namespace Ace.Geograpi.ArchitectureTests.Layers.Infrastructure.Repositories;

public sealed class InfrastructureRepositoryArchUnitNetTests : ArchUnitNetBase
{
    [Fact]
    internal static void InfrastructureRepositoriesShouldMatchNamespace()
    {
        // Arrange
        var rule = infrastructureRepositories.Should().ResideInNamespaceMatching(NamespacePatterns.InfrastructureRepositories);

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal static void InfrastructureRepositoriesShouldHaveRepositoryPostfix()
    {
        // Arrange
        var rule = infrastructureRepositories.Should().HaveNameEndingWith("Repository");

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal static void InfrastructureRepositoriesShouldBeInternal()
    {
        // Arrange
        var rule = infrastructureRepositories.Should().BeInternal();

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal static void InfrastructureRepositoriesShouldBeSealed()
    {
        // Arrange
        var rule = infrastructureRepositories.Should().BeSealed();

        // Act / Assert
        rule.Check(architecture);
    }
}
