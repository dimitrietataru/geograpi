using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;
using ArchUnitNET.xUnit;

namespace Ace.Geograpi.ArchitectureTests.Layers.Domain.Models;

public sealed class DomainModelArchUnitNetTests : ArchUnitNetBase
{
    [Fact]
    internal void DomainModelsShouldMatchNamespace()
    {
        // Arrange
        var rule = domainModels.Should().ResideInNamespaceMatching(NamespacePatterns.DomainModels);

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void DomainModelsShouldHaveModelPostfix()
    {
        // Arrange
        var rule = domainModels.Should().HaveNameEndingWith("Model");

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void DomainModelsShouldBePublic()
    {
        // Arrange
        var rule = domainModels.Should().BePublic();

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void DomainModelsShouldBeSealed()
    {
        // Arrange
        var rule = domainModels.Should().BeSealed();

        // Act / Assert
        rule.Check(architecture);
    }
}
