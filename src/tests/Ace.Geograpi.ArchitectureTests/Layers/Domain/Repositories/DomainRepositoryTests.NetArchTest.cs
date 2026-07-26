using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;

namespace Ace.Geograpi.ArchitectureTests.Layers.Domain.Repositories;

public sealed class DomainRepositoryNetArchTestTests : NetArchTestBase
{
    [Fact]
    internal void DomainRepositoriesShouldMatchNamespace()
    {
        // Arrange
        var rule = domainRepositories.Should().ResideInNamespaceMatching(NamespacePatterns.DomainRepositories);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal void DomainRepositoriesShouldHaveISuffix()
    {
        // Arrange
        var rule = domainRepositories.Should().HaveNameStartingWith("I", StringComparison.Ordinal);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal void DomainRepositoriesShouldHaveRepositoryPostfix()
    {
        // Arrange
        var rule = domainRepositories.Should().HaveNameEndingWith("Repository", StringComparison.Ordinal);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal void DomainRepositoriesShouldBePublic()
    {
        // Arrange
        var rule = domainRepositories.Should().BePublic();

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }
}
