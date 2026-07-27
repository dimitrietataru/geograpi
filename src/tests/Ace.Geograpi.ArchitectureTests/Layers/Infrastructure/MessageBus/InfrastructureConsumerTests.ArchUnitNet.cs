using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;
using ArchUnitNET.xUnit;

namespace Ace.Geograpi.ArchitectureTests.Layers.Infrastructure.MessageBus;

public sealed class InfrastructureConsumerArchUnitNetTests : ArchUnitNetBase
{
    [Fact]
    internal void InfrastructureConsumersShouldMatchNamespace()
    {
        // Arrange
        var rule = infrastructureConsumers.Should().ResideInNamespaceMatching(NamespacePatterns.InfrastructureConsumers);

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void InfrastructureConsumersShouldHaveMappingProfilePostfix()
    {
        // Arrange
        var rule = infrastructureConsumers.Should().HaveNameEndingWith("Consumer");

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void InfrastructureConsumersShouldBeInternal()
    {
        // Arrange
        var rule = infrastructureConsumers.Should().BeInternal();

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void InfrastructureConsumersShouldBeSealed()
    {
        // Arrange
        var rule = infrastructureConsumers.Should().BeSealed();

        // Act / Assert
        rule.Check(architecture);
    }
}
