using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;

namespace Ace.Geograpi.ArchitectureTests.Layers.Application.Services;

public sealed class ApplicationServiceNetArchTestTests : NetArchTestBase
{
    [Fact]
    internal static void ApplicationServicesShouldMatchNamespace()
    {
        // Arrange
        var rule = applicationServices.Should().ResideInNamespaceMatching(NamespacePatterns.ApplicationServices);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

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
