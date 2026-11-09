using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;

namespace Ace.Geograpi.ArchitectureTests.Layers.Domain.Repositories;

public sealed class DomainRepositoryNetArchTestTests : NetArchTestBase
{
    [Fact]
    internal void DomainRepositoriesShouldBeDefined()
    {
        // Arrange / Act
        var types = domainRepositories.GetTypes();

        // Assert
        types.Should().NotBeEmpty();
    }

    [Fact]
    internal void DomainRepositoriesShouldMatchNamespace()
    {
        // Arrange
        var rule = domainRepositories.Should().ResideInNamespaceMatching(NamespacePatterns.DomainRepositories);

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void DomainRepositoriesShouldHaveIPrefix()
    {
        // Arrange
        var rule = domainRepositories.Should().HaveNameStartingWith("I", StringComparison.Ordinal);

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void DomainRepositoriesShouldHaveRepositorySuffix()
    {
        // Arrange
        var rule = domainRepositories.Should().HaveNameEndingWith("Repository", StringComparison.Ordinal);

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void DomainRepositoriesShouldBePublic()
    {
        // Arrange
        var rule = domainRepositories.Should().BePublic();

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }
}
