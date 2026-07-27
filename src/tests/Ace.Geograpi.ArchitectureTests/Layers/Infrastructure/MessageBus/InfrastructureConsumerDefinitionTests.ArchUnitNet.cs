using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;
using ArchUnitNET.xUnit;

namespace Ace.Geograpi.ArchitectureTests.Layers.Infrastructure.MessageBus;

public sealed class InfrastructureConsumerDefinitionArchUnitNetTests : ArchUnitNetBase
{
    [Fact]
    internal void InfrastructureConsumerDefinitionsShouldMatchNamespace()
    {
        // Arrange
        var rule = infrastructureConsumerDefinitions.Should().ResideInNamespaceMatching(NamespacePatterns.InfrastructureConsumerDefinitions);

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void InfrastructureConsumerDefinitionsShouldHaveMappingProfilePostfix()
    {
        // Arrange
        var rule = infrastructureConsumerDefinitions.Should().HaveNameEndingWith("ConsumerDefinition");

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void InfrastructureConsumerDefinitionsShouldBeInternal()
    {
        // Arrange
        var rule = infrastructureConsumerDefinitions.Should().BeInternal();

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void InfrastructureConsumerDefinitionsShouldBeSealed()
    {
        // Arrange
        var rule = infrastructureConsumerDefinitions.Should().BeSealed();

        // Act / Assert
        rule.Check(architecture);
    }
}
