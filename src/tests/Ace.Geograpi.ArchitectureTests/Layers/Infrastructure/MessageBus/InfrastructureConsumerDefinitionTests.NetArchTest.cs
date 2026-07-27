using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;

namespace Ace.Geograpi.ArchitectureTests.Layers.Infrastructure.MessageBus;

public sealed class InfrastructureConsumerDefinitionNetArchTestTests : NetArchTestBase
{
    [Fact]
    internal void InfrastructureConsumerDefinitionsShouldMatchNamespace()
    {
        // Arrange
        var rule = infrastructureConsumerDefinitions.Should().ResideInNamespaceMatching(NamespacePatterns.InfrastructureConsumerDefinitions);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal void InfrastructureConsumerDefinitionsShouldHaveMappingProfilePostfix()
    {
        // Arrange
        var rule = infrastructureConsumerDefinitions.Should().HaveNameEndingWith("ConsumerDefinition", StringComparison.Ordinal);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal void InfrastructureConsumerDefinitionsShouldBeInternal()
    {
        // Arrange
        var rule = infrastructureConsumerDefinitions.Should().NotBePublic();

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal void InfrastructureConsumerDefinitionsShouldBeSealed()
    {
        // Arrange
        var rule = infrastructureConsumerDefinitions.Should().BeSealed();

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }
}
