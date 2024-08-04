using Ace.Geograpi.ArchitectureTests.Abstractions;

namespace Ace.Geograpi.ArchitectureTests.Layers.Infrastructure.Data.Configurations;

public sealed class InfrastructureConfigurationNetArchTestTests : NetArchTestBase
{
    [Fact]
    internal static void InfrastructureConfigurationsShouldHaveConfigurationPostfix()
    {
        // Arrange
        var rule = infrastructureDataConfigurations.Should().HaveNameEndingWith("Configuration", StringComparison.Ordinal);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal static void InfrastructureConfigurationsShouldBeInternal()
    {
        // Arrange
        var rule = infrastructureDataConfigurations.Should().NotBePublic();

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal static void InfrastructureConfigurationsShouldBeSealed()
    {
        // Arrange
        var rule = infrastructureDataConfigurations.Should().BeSealed();

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }
}
