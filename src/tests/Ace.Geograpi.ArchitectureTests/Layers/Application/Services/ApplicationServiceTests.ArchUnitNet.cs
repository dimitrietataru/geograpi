using Ace.Geograpi.ArchitectureTests.Abstractions;
using ArchUnitNET.xUnit;

namespace Ace.Geograpi.ArchitectureTests.Layers.Application.Services;

public sealed class ApplicationServiceArchUnitNetTests : ArchUnitNetBase
{
    [Fact]
    internal static void ApplicationServicesShouldHaveServicePostfix()
    {
        // Arrange
        var rule = applicationServices.Should().HaveNameEndingWith("Service");

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal static void ApplicationServicesShouldBePublic()
    {
        // Arrange
        var rule = applicationServices.Should().BePublic();

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal static void ApplicationServicesShouldBeSealed()
    {
        // Arrange
        var rule = applicationServices.Should().BeSealed();

        // Act / Assert
        rule.Check(architecture);
    }
}
