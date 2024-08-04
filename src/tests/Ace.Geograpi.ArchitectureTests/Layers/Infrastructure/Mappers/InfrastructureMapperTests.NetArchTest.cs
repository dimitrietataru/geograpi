using Ace.Geograpi.ArchitectureTests.Abstractions;

namespace Ace.Geograpi.ArchitectureTests.Layers.Infrastructure.Mappers;

public sealed class InfrastructureMapperNetArchTestTests : NetArchTestBase
{
    [Fact]
    internal static void InfrastructureMappersShouldHaveMappingProfilePostfix()
    {
        // Arrange
        var rule = infrastructureMappers.Should().HaveNameEndingWith("MappingProfile", StringComparison.Ordinal);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal static void InfrastructureMappersShouldBePublic()
    {
        // Arrange
        var rule = infrastructureMappers.Should().BePublic();

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal static void InfrastructureMappersShouldBeSealed()
    {
        // Arrange
        var rule = infrastructureMappers.Should().BeSealed();

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }
}
