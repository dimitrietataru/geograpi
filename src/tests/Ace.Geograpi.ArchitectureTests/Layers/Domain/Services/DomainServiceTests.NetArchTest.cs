using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;

namespace Ace.Geograpi.ArchitectureTests.Layers.Domain.Services;

public sealed class DomainServiceNetArchTestTests : NetArchTestBase
{
    [Fact]
    internal static void DomainServicesShouldMatchNamespace()
    {
        // Arrange
        var rule = domainServices.Should().ResideInNamespaceMatching(NamespacePatterns.DomainServices);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal static void DomainServicesShouldHaveISuffix()
    {
        // Arrange
        var rule = domainServices.Should().HaveNameStartingWith("I", StringComparison.Ordinal);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal static void DomainServicesShouldHaveServicePostfix()
    {
        // Arrange
        var rule = domainServices.Should().HaveNameEndingWith("Service", StringComparison.Ordinal);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal static void DomainServicesShouldBePublic()
    {
        // Arrange
        var rule = domainServices.Should().BePublic();

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }
}
