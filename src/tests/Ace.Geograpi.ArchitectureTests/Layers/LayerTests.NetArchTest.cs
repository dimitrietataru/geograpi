using Ace.Geograpi.ArchitectureTests.Abstractions;

namespace Ace.Geograpi.ArchitectureTests.Layers;

public sealed class LayerNetArchTestTests : NetArchTestBase
{
    [Fact]
    internal static void DomainShouldNotHaveDependencyOnApplication()
    {
        // Arrange
        var rule = domainTypes.Should().NotHaveDependencyOn(applicationAssembly.GetName().Name);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal static void DomainShouldNotHaveDependencyOnInfrastructure()
    {
        // Arrange
        var rule = domainTypes.Should().NotHaveDependencyOn(infrastructureAssembly.GetName().Name);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal static void DomainShouldNotHaveDependencyOnWeb()
    {
        // Arrange
        var rule = domainTypes.Should().NotHaveDependencyOn(webAssembly.GetName().Name);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal static void ApplicationShouldNotHaveDependencyOnInfrastructure()
    {
        // Arrange
        var rule = applicationTypes.Should().NotHaveDependencyOn(infrastructureAssembly.GetName().Name);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal static void ApplicationShouldNotHaveDependencyOnWeb()
    {
        // Arrange
        var rule = applicationTypes.Should().NotHaveDependencyOn(webAssembly.GetName().Name);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal static void InfrastructureShouldNotHaveDependencyOnApplication()
    {
        // Arrange
        var rule = infrastructureTypes.Should().NotHaveDependencyOn(applicationAssembly.GetName().Name);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal static void InfrastructureShouldNotHaveDependencyOnWeb()
    {
        // Arrange
        var rule = infrastructureTypes.Should().NotHaveDependencyOn(webAssembly.GetName().Name);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }
}
