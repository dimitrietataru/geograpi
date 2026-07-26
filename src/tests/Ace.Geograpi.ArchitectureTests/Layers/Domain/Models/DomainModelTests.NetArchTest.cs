using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;

namespace Ace.Geograpi.ArchitectureTests.Layers.Domain.Models;

public sealed class DomainModelNetArchTestTests : NetArchTestBase
{
    [Fact]
    internal void DomainModelsShouldMatchNamespace()
    {
        // Arrange
        var rule = domainModels.Should().ResideInNamespaceMatching(NamespacePatterns.DomainModels);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal void DomainModelsShouldHaveModelPostfix()
    {
        // Arrange
        var rule = domainModels.Should().HaveNameEndingWith("Model", StringComparison.Ordinal);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal void DomainModelsShouldBePublic()
    {
        // Arrange
        var rule = domainModels.Should().BePublic();

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal void DomainModelsShouldBeSealed()
    {
        // Arrange
        var rule = domainModels.Should().BeSealed();

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }
}
