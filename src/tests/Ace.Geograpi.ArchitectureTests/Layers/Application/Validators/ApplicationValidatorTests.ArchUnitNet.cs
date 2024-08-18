using Ace.Geograpi.ArchitectureTests.Abstractions;
using ArchUnitNET.xUnit;

namespace Ace.Geograpi.ArchitectureTests.Layers.Application.Validators;

public sealed class ApplicationValidatorArchUnitNetTests : ArchUnitNetBase
{
    [Fact]
    internal static void ApplicationValidatorsShouldHaveValidatorPostfix()
    {
        // Arrange
        var rule = applicationValidators.Should().HaveNameEndingWith("Validator");

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal static void ApplicationValidatorsShouldBeInternal()
    {
        // Arrange
        var rule = applicationValidators.Should().BeInternal();

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal static void ApplicationValidatorsShouldBeSealed()
    {
        // Arrange
        var rule = applicationValidators.Should().BeSealed();

        // Act / Assert
        rule.Check(architecture);
    }
}
