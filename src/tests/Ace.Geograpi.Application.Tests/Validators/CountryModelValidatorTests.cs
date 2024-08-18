using Ace.Geograpi.Application.Validators;
using Ace.Geograpi.Domain.Models;

namespace Ace.Geograpi.Application.Tests.Validators;

public sealed class CountryModelValidatorTests
{
    private readonly IValidator<CountryModel> countryModelValidator;

    public CountryModelValidatorTests()
    {
        countryModelValidator = new CountryModelValidator();
    }

    [Fact]
    internal void GivenValidateWhenDataIsValidThenAuditPasses()
    {
        // Arrange
        var country = new CountryModel
        {
            Id = 0,
            ContinentId = 1,
            Name = "Foo"
        };

        // Act
        var validationResult = countryModelValidator.TestValidate(country);

        // Assert
        validationResult.ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    internal void GivenValidateWhenContinentIdIsDefaultThenAuditFails()
    {
        // Arrange
        var country = new CountryModel
        {
            Id = 0,
            ContinentId = default,
            Name = "Foo"
        };

        // Act
        var validationResult = countryModelValidator.TestValidate(country);

        // Assert
        validationResult.ShouldHaveValidationErrorFor(c => c.ContinentId);
        validationResult.ShouldNotHaveValidationErrorFor(c => c.Name);
    }

    [Fact]
    internal void GivenValidateWhenNameIsNullThenAuditFails()
    {
        // Arrange
        var country = new CountryModel
        {
            Id = 0,
            ContinentId = 1,
            Name = null!
        };

        // Act
        var validationResult = countryModelValidator.TestValidate(country);

        // Assert
        validationResult.ShouldNotHaveValidationErrorFor(c => c.ContinentId);
        validationResult.ShouldHaveValidationErrorFor(c => c.Name);
    }

    [Fact]
    internal void GivenValidateWhenNameIsEmptyThenAuditFails()
    {
        // Arrange
        var country = new CountryModel
        {
            Id = 0,
            ContinentId = 1,
            Name = string.Empty
        };

        // Act
        var validationResult = countryModelValidator.TestValidate(country);

        // Assert
        validationResult.ShouldNotHaveValidationErrorFor(c => c.ContinentId);
        validationResult.ShouldHaveValidationErrorFor(c => c.Name);
    }

    [Fact]
    internal void GivenValidateWhenNameIsTooLongThenAuditFails()
    {
        // Arrange
        var country = new CountryModel
        {
            Id = 0,
            ContinentId = 1,
            Name = new string('*', 101)
        };

        // Act
        var validationResult = countryModelValidator.TestValidate(country);

        // Assert
        validationResult.ShouldNotHaveValidationErrorFor(c => c.ContinentId);
        validationResult.ShouldHaveValidationErrorFor(c => c.Name);
    }
}
