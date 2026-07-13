using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;

namespace Ace.Geograpi.ArchitectureTests.Layers.Infrastructure.Repositories;

public sealed class InfrastructureRepositoryNetArchTestTests : NetArchTestBase
{
    [Fact]
    internal static void InfrastructureRepositoriesShouldMatchNamespace()
    {
        // Arrange
        var rule = infrastructureRepositories.Should().ResideInNamespaceMatching(NamespacePatterns.InfrastructureRepositories);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal static void InfrastructureRepositoriesShouldHaveRepositoryPostfix()
    {
        // Arrange
        var rule = infrastructureRepositories.Should().HaveNameEndingWith("Repository", StringComparison.Ordinal);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal static void InfrastructureRepositoriesShouldBeInternal()
    {
        // Arrange
        var rule = infrastructureRepositories.Should().NotBePublic();

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal static void InfrastructureRepositoriesShouldBeSealed()
    {
        // Arrange
        var rule = infrastructureRepositories.Should().BeSealed();

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }
}
