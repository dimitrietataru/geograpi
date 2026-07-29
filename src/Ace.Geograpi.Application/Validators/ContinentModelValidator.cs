using Ace.Geograpi.Domain.Models;
using Ace.Geograpi.Domain.Symbols;

namespace Ace.Geograpi.Application.Validators;

internal sealed class ContinentModelValidator : AbstractValidator<ContinentModel>
{
    public ContinentModelValidator()
    {
        RegisterRulesForName();
    }

    private void RegisterRulesForName()
    {
        RuleFor(continent => continent.Name)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .MaximumLength(Constraints.ContinentNameMaxLength);
    }
}
