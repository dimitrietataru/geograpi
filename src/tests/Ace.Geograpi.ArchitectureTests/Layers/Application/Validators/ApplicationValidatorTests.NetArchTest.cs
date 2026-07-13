using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;

namespace Ace.Geograpi.ArchitectureTests.Layers.Application.Validators;

public sealed class ApplicationValidatorNetArchTestTests : NetArchTestBase
{
    [Fact]
    internal static void ApplicationValidatorsShouldMatchNamespace()
    {
        // Arrange
        var rule = applicationValidators.Should().ResideInNamespaceMatching(NamespacePatterns.ApplicationValidators);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal static void ApplicationValidatorsShouldHaveValidatorPostfix()
    {
        // Arrange
        var rule = applicationValidators.Should().HaveNameEndingWith("Validator", StringComparison.Ordinal);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal static void ApplicationValidatorsShouldBeInternal()
    {
        // Arrange
        var rule = applicationValidators.Should().NotBePublic();

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal static void ApplicationValidatorsShouldBeSealed()
    {
        // Arrange
        var rule = applicationValidators.Should().BeSealed();

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }
}
