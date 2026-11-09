using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;

namespace Ace.Geograpi.ArchitectureTests.Layers.Application.Validators;

public sealed class ApplicationValidatorNetArchTestTests : NetArchTestBase
{
    [Fact]
    internal void ApplicationValidatorsShouldBeDefined()
    {
        // Arrange / Act
        var types = applicationValidators.GetTypes();

        // Assert
        types.Should().NotBeEmpty();
    }

    [Fact]
    internal void ApplicationValidatorsShouldMatchNamespace()
    {
        // Arrange
        var rule = applicationValidators.Should().ResideInNamespaceMatching(NamespacePatterns.ApplicationValidators);

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void ApplicationValidatorsShouldHaveValidatorSuffix()
    {
        // Arrange
        var rule = applicationValidators.Should().HaveNameEndingWith("Validator", StringComparison.Ordinal);

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void ApplicationValidatorsShouldBeInternal()
    {
        // Arrange
        var rule = applicationValidators.Should().NotBePublic();

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void ApplicationValidatorsShouldBeSealed()
    {
        // Arrange
        var rule = applicationValidators.Should().BeSealed();

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }
}
