using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;

namespace Ace.Geograpi.ArchitectureTests.Layers.Domain.QueryFilters;

public sealed class DomainQueryFilterNetArchTestTests : NetArchTestBase
{
    [Fact]
    internal static void DomainQueryFiltersShouldMatchNamespace()
    {
        // Arrange
        var rule = domainQueryFilters.Should().ResideInNamespaceMatching(NamespacePatterns.DomainQueryFilters);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal static void DomainQueryFiltersShouldHaveQueryFilterPostfix()
    {
        // Arrange
        var rule = domainQueryFilters.Should().HaveNameEndingWith("QueryFilter", StringComparison.Ordinal);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal static void DomainQueryFiltersShouldBePublic()
    {
        // Arrange
        var rule = domainQueryFilters.Should().BePublic();

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal static void DomainQueryFiltersShouldBeSealed()
    {
        // Arrange
        var rule = domainQueryFilters.Should().BeSealed();

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }
}
