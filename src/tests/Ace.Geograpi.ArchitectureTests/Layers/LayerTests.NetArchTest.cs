using Ace.Geograpi.ArchitectureTests.Abstractions;

namespace Ace.Geograpi.ArchitectureTests.Layers;

public sealed class LayerNetArchTestTests : NetArchTestBase
{
    [Fact]
    internal void DomainShouldNotHaveDependencyOnApplication()
    {
        // Arrange
        var rule = DomainTypes.Should().NotHaveDependencyOn(applicationAssembly.GetName().Name);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal void DomainShouldNotHaveDependencyOnInfrastructure()
    {
        // Arrange
        var rule = DomainTypes.Should().NotHaveDependencyOn(infrastructureAssembly.GetName().Name);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal void DomainShouldNotHaveDependencyOnWeb()
    {
        // Arrange
        var rule = DomainTypes.Should().NotHaveDependencyOn(webAssembly.GetName().Name);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal void ApplicationShouldNotHaveDependencyOnInfrastructure()
    {
        // Arrange
        var rule = ApplicationTypes.Should().NotHaveDependencyOn(infrastructureAssembly.GetName().Name);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal void ApplicationShouldNotHaveDependencyOnWeb()
    {
        // Arrange
        var rule = DomainTypes.Should().NotHaveDependencyOn(webAssembly.GetName().Name);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal void InfrastructureShouldNotHaveDependencyOnApplication()
    {
        // Arrange
        var rule = InfrastructureTypes.Should().NotHaveDependencyOn(applicationAssembly.GetName().Name);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal void InfrastructureShouldNotHaveDependencyOnWeb()
    {
        // Arrange
        var rule = InfrastructureTypes.Should().NotHaveDependencyOn(webAssembly.GetName().Name);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }
}
