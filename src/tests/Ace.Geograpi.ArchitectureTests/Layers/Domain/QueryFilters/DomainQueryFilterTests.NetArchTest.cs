using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;

namespace Ace.Geograpi.ArchitectureTests.Layers.Domain.QueryFilters;

public sealed class DomainQueryFilterNetArchTestTests : NetArchTestBase
{
    [Fact]
    internal void DomainQueryFiltersShouldBeDefined()
    {
        // Arrange / Act
        var types = domainQueryFilters.GetTypes();

        // Assert
        types.Should().NotBeEmpty();
    }

    [Fact]
    internal void DomainQueryFiltersShouldMatchNamespace()
    {
        // Arrange
        var rule = domainQueryFilters.Should().ResideInNamespaceMatching(NamespacePatterns.DomainQueryFilters);

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void DomainQueryFiltersShouldHaveQueryFilterSuffix()
    {
        // Arrange
        var rule = domainQueryFilters.Should().HaveNameEndingWith("QueryFilter", StringComparison.Ordinal);

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void DomainQueryFiltersShouldBePublic()
    {
        // Arrange
        var rule = domainQueryFilters.Should().BePublic();

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void DomainQueryFiltersShouldBeSealed()
    {
        // Arrange
        var rule = domainQueryFilters.Should().BeSealed();

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }
}
