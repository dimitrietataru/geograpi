using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;
using ArchUnitNET.xUnit;

namespace Ace.Geograpi.ArchitectureTests.Layers.Application.Validators;

public sealed class ApplicationValidatorArchUnitNetTests : ArchUnitNetBase
{
    [Fact]
    internal void ApplicationValidatorsShouldMatchNamespace()
    {
        // Arrange
        var rule = applicationValidators.Should().ResideInNamespaceMatching(NamespacePatterns.ApplicationValidators);

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void ApplicationValidatorsShouldHaveValidatorPostfix()
    {
        // Arrange
        var rule = applicationValidators.Should().HaveNameEndingWith("Validator");

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void ApplicationValidatorsShouldBeInternal()
    {
        // Arrange
        var rule = applicationValidators.Should().BeInternal();

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void ApplicationValidatorsShouldBeSealed()
    {
        // Arrange
        var rule = applicationValidators.Should().BeSealed();

        // Act / Assert
        rule.Check(architecture);
    }
}
