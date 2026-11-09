using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;

namespace Ace.Geograpi.ArchitectureTests.Layers.Infrastructure.MessageBus;

public sealed class InfrastructureConsumerDefinitionNetArchTestTests : NetArchTestBase
{
    [Fact]
    internal void InfrastructureConsumerDefinitionsShouldBeDefined()
    {
        // Arrange / Act
        var types = infrastructureConsumerDefinitions.GetTypes();

        // Assert
        types.Should().NotBeEmpty();
    }

    [Fact]
    internal void InfrastructureConsumerDefinitionsShouldMatchNamespace()
    {
        // Arrange
        var rule = infrastructureConsumerDefinitions.Should().ResideInNamespaceMatching(NamespacePatterns.InfrastructureConsumerDefinitions);

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void InfrastructureConsumerDefinitionsShouldHaveConsumerDefinitionSuffix()
    {
        // Arrange
        var rule = infrastructureConsumerDefinitions.Should().HaveNameEndingWith("ConsumerDefinition", StringComparison.Ordinal);

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void InfrastructureConsumerDefinitionsShouldBeInternal()
    {
        // Arrange
        var rule = infrastructureConsumerDefinitions.Should().NotBePublic();

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void InfrastructureConsumerDefinitionsShouldBeSealed()
    {
        // Arrange
        var rule = infrastructureConsumerDefinitions.Should().BeSealed();

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }
}
