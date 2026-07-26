using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;
using ArchUnitNET.xUnit;

namespace Ace.Geograpi.ArchitectureTests.Layers.Domain.Services;

public sealed class DomainServiceArchUnitNetTests : ArchUnitNetBase
{
    [Fact]
    internal void DomainServicesShouldMatchNamespace()
    {
        // Arrange
        var rule = domainServices.Should().ResideInNamespaceMatching(NamespacePatterns.DomainServices);

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void DomainServicesShouldHaveISuffix()
    {
        // Arrange
        var rule = domainServices.Should().HaveNameStartingWith("I");

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void DomainServicesShouldHaveServicePostfix()
    {
        // Arrange
        var rule = domainServices.Should().HaveNameEndingWith("Service");

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void DomainServicesShouldBePublic()
    {
        // Arrange
        var rule = domainServices.Should().BePublic();

        // Act / Assert
        rule.Check(architecture);
    }
}
