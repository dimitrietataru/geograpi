using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;
using ArchUnitNET.xUnit;

namespace Ace.Geograpi.ArchitectureTests.Layers.Domain.Events;

public sealed class DomainEventArchUnitNetTests : ArchUnitNetBase
{
    [Fact]
    internal static void DomainEventsShouldMatchNamespace()
    {
        // Arrange
        var rule = domainEvents.Should().ResideInNamespaceMatching(NamespacePatterns.DomainEvents);

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal static void DomainEventsShouldHaveEventPostfix()
    {
        // Arrange
        var rule = domainEvents.Should().HaveNameEndingWith("Event");

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal static void DomainEventsShouldBePublic()
    {
        // Arrange
        var rule = domainEvents.Should().BePublic();

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal static void DomainEventsShouldBeSealed()
    {
        // Arrange
        var rule = domainEvents.Should().BeSealed();

        // Act / Assert
        rule.Check(architecture);
    }
}
