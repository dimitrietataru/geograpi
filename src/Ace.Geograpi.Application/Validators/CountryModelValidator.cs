using Ace.Geograpi.Domain.Models;

namespace Ace.Geograpi.Application.Validators;

internal sealed class CountryModelValidator : AbstractValidator<CountryModel>
{
    public CountryModelValidator()
    {
        RegisterRulesForContinentId();
        RegisterRulesForName();
    }

    private void RegisterRulesForContinentId()
    {
        RuleFor(country => country.ContinentId)
            .Cascade(CascadeMode.Stop)
            .GreaterThanOrEqualTo(1);
    }

    private void RegisterRulesForName()
    {
        RuleFor(country => country.Name)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .MaximumLength(100);
    }
}
