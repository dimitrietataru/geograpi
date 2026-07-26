using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;

namespace Ace.Geograpi.ArchitectureTests.Layers.Domain.Events;

public sealed class DomainEventNetArchTestTests : NetArchTestBase
{
    [Fact]
    internal void DomainEventsShouldMatchNamespace()
    {
        // Arrange
        var rule = domainEvents.Should().ResideInNamespaceMatching(NamespacePatterns.DomainEvents);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal void DomainEventsShouldHaveEventPostfix()
    {
        // Arrange
        var rule = domainEvents.Should().HaveNameEndingWith("Event", StringComparison.Ordinal);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal void DomainEventsShouldBePublic()
    {
        // Arrange
        var rule = domainEvents.Should().BePublic();

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal void DomainEventsShouldBeSealed()
    {
        // Arrange
        var rule = domainEvents.Should().BeSealed();

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }
}
