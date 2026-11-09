using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;

namespace Ace.Geograpi.ArchitectureTests.Layers.Infrastructure.MessageBus;

public sealed class InfrastructureConsumerNetArchTestTests : NetArchTestBase
{
    [Fact]
    internal void InfrastructureConsumersShouldBeDefined()
    {
        // Arrange / Act
        var types = infrastructureConsumers.GetTypes();

        // Assert
        types.Should().NotBeEmpty();
    }

    [Fact]
    internal void InfrastructureConsumersShouldMatchNamespace()
    {
        // Arrange
        var rule = infrastructureConsumers.Should().ResideInNamespaceMatching(NamespacePatterns.InfrastructureConsumers);

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void InfrastructureConsumersShouldHaveConsumerSuffix()
    {
        // Arrange
        var rule = infrastructureConsumers.Should().HaveNameEndingWith("Consumer", StringComparison.Ordinal);

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void InfrastructureConsumersShouldBeInternal()
    {
        // Arrange
        var rule = infrastructureConsumers.Should().NotBePublic();

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void InfrastructureConsumersShouldBeSealed()
    {
        // Arrange
        var rule = infrastructureConsumers.Should().BeSealed();

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }
}
