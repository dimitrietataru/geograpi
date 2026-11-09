using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;

namespace Ace.Geograpi.ArchitectureTests.Layers.Domain.Services;

public sealed class DomainServiceNetArchTestTests : NetArchTestBase
{
    [Fact]
    internal void DomainServicesShouldBeDefined()
    {
        // Arrange / Act
        var types = domainServices.GetTypes();

        // Assert
        types.Should().NotBeEmpty();
    }

    [Fact]
    internal void DomainServicesShouldMatchNamespace()
    {
        // Arrange
        var rule = domainServices.Should().ResideInNamespaceMatching(NamespacePatterns.DomainServices);

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void DomainServicesShouldHaveIPrefix()
    {
        // Arrange
        var rule = domainServices.Should().HaveNameStartingWith("I", StringComparison.Ordinal);

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void DomainServicesShouldHaveServiceSuffix()
    {
        // Arrange
        var rule = domainServices.Should().HaveNameEndingWith("Service", StringComparison.Ordinal);

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void DomainServicesShouldBePublic()
    {
        // Arrange
        var rule = domainServices.Should().BePublic();

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }
}
