using Ace.Geograpi.Application.Validators;
using Ace.Geograpi.Domain.Models;

namespace Ace.Geograpi.Application.Tests.Validators;

public sealed class ContinentModelValidatorTests
{
    private readonly IValidator<ContinentModel> continentModelValidator;

    public ContinentModelValidatorTests()
    {
        continentModelValidator = new ContinentModelValidator();
    }

    [Fact]
    internal void GivenValidateWhenDataIsValidThenAuditPasses()
    {
        // Arrange
        var continent = new ContinentModel
        {
            Id = 0,
            Name = "Foo"
        };

        // Act
        var validationResult = continentModelValidator.TestValidate(continent);

        // Assert
        validationResult.ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    internal void GivenValidateWhenNameIsNullThenAuditFails()
    {
        // Arrange
        var continent = new ContinentModel
        {
            Id = 0,
            Name = null!
        };

        // Act
        var validationResult = continentModelValidator.TestValidate(continent);

        // Assert
        validationResult.ShouldHaveValidationErrorFor(c => c.Name);
    }

    [Fact]
    internal void GivenValidateWhenNameIsEmptyThenAuditFails()
    {
        // Arrange
        var continent = new ContinentModel
        {
            Id = 0,
            Name = string.Empty
        };

        // Act
        var validationResult = continentModelValidator.TestValidate(continent);

        // Assert
        validationResult.ShouldHaveValidationErrorFor(c => c.Name);
    }

    [Fact]
    internal void GivenValidateWhenNameIsTooLongThenAuditFails()
    {
        // Arrange
        var continent = new ContinentModel
        {
            Id = 0,
            Name = new string('*', 101)
        };

        // Act
        var validationResult = continentModelValidator.TestValidate(continent);

        // Assert
        validationResult.ShouldHaveValidationErrorFor(c => c.Name);
    }
}
