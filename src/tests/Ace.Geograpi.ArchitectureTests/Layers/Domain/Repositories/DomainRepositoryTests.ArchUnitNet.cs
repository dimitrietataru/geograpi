using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;
using ArchUnitNET.xUnitV3;

namespace Ace.Geograpi.ArchitectureTests.Layers.Domain.Repositories;

public sealed class DomainRepositoryArchUnitNetTests : ArchUnitNetBase
{
    [Fact]
    internal void DomainRepositoriesShouldBeDefined()
    {
        // Arrange / Act
        var types = domainRepositories.GetObjects(architecture);

        // Assert
        types.Should().NotBeEmpty();
    }

    [Fact]
    internal void DomainRepositoriesShouldMatchNamespace()
    {
        // Arrange
        var rule = domainRepositories.Should().ResideInNamespaceMatching(NamespacePatterns.DomainRepositories);

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void DomainRepositoriesShouldHaveIPrefix()
    {
        // Arrange
        var rule = domainRepositories.Should().HaveNameStartingWith("I");

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void DomainRepositoriesShouldHaveRepositorySuffix()
    {
        // Arrange
        var rule = domainRepositories.Should().HaveNameEndingWith("Repository");

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void DomainRepositoriesShouldBePublic()
    {
        // Arrange
        var rule = domainRepositories.Should().BePublic();

        // Act / Assert
        rule.Check(architecture);
    }
}
