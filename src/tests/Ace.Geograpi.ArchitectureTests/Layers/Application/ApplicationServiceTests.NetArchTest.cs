using Ace.Geograpi.ArchitectureTests.Abstractions;

namespace Ace.Geograpi.ArchitectureTests.Layers.Application;

public sealed class ApplicationServiceNetArchTestTests : NetArchTestBase
{
    [Fact]
    internal static void ApplicationServicesShouldHaveServicePostfix()
    {
        // Arrange
        var rule = applicationServices.Should().HaveNameEndingWith("Service", StringComparison.Ordinal);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal static void ApplicationServicesShouldBePublic()
    {
        // Arrange
        var rule = applicationServices.Should().BePublic();

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal static void ApplicationServicesShouldBeSealed()
    {
        // Arrange
        var rule = applicationServices.Should().BeSealed();

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }
}
