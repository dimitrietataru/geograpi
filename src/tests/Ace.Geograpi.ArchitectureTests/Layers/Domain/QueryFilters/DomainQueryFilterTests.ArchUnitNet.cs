using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;
using ArchUnitNET.xUnit;

namespace Ace.Geograpi.ArchitectureTests.Layers.Domain.QueryFilters;

public sealed class DomainQueryFilterArchUnitNetTests : ArchUnitNetBase
{
    [Fact]
    internal static void DomainQueryFiltersShouldMatchNamespace()
    {
        // Arrange
        var rule = domainQueryFilters.Should().ResideInNamespaceMatching(NamespacePatterns.DomainQueryFilters);

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal static void DomainQueryFiltersShouldHaveQueryFilterPostfix()
    {
        // Arrange
        var rule = domainQueryFilters.Should().HaveNameEndingWith("QueryFilter");

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal static void DomainQueryFiltersShouldBePublic()
    {
        // Arrange
        var rule = domainQueryFilters.Should().BePublic();

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal static void DomainQueryFiltersShouldBeSealed()
    {
        // Arrange
        var rule = domainQueryFilters.Should().BeSealed();

        // Act / Assert
        rule.Check(architecture);
    }
}
