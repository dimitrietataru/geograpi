using Ace.Geograpi.ArchitectureTests.Abstractions;

namespace Ace.Geograpi.ArchitectureTests.Layers;

public sealed class LayerNetArchTestTests : NetArchTestBase
{
    [Fact]
    internal void DomainShouldOnlyDependOnAllowedTypes()
    {
        // Arrange
        var rule = DomainTypes.Should().OnlyHaveDependenciesOn(
            domainAssembly.GetName().Name,
            "CatNip.Domain",
            "System");

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void DomainShouldNotHaveDependencyOnApplication()
    {
        // Arrange
        var rule = DomainTypes.Should().NotHaveDependencyOn(applicationAssembly.GetName().Name);

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void DomainShouldNotHaveDependencyOnInfrastructure()
    {
        // Arrange
        var rule = DomainTypes.Should().NotHaveDependencyOn(infrastructureAssembly.GetName().Name);

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void DomainShouldNotHaveDependencyOnWeb()
    {
        // Arrange
        var rule = DomainTypes.Should().NotHaveDependencyOn(webAssembly.GetName().Name);

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void ApplicationShouldNotHaveDependencyOnInfrastructure()
    {
        // Arrange
        var rule = ApplicationTypes.Should().NotHaveDependencyOn(infrastructureAssembly.GetName().Name);

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void ApplicationShouldNotHaveDependencyOnWeb()
    {
        // Arrange
        var rule = ApplicationTypes.Should().NotHaveDependencyOn(webAssembly.GetName().Name);

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void InfrastructureShouldNotHaveDependencyOnApplication()
    {
        // Arrange
        var rule = InfrastructureTypes.Should().NotHaveDependencyOn(applicationAssembly.GetName().Name);

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void InfrastructureShouldNotHaveDependencyOnWeb()
    {
        // Arrange
        var rule = InfrastructureTypes.Should().NotHaveDependencyOn(webAssembly.GetName().Name);

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void WebShouldOnlyHaveDependencyOnApplicationForDI()
    {
        // Arrange
        var rule = WebTypes
            .That().DoNotHaveName("Program")
            .Should().NotHaveDependencyOn(applicationAssembly.GetName().Name);

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void WebShouldOnlyHaveDependencyOnInfrastructureForDI()
    {
        // Arrange
        var rule = WebTypes
            .That().DoNotHaveName("Program")
            .And().DoNotHaveName("AppConfiguration")
            .Should().NotHaveDependencyOn(infrastructureAssembly.GetName().Name);

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }
}
