using Ace.CSharp.DataFaker;
using Ace.Geograpi.Domain.Models;
using Ace.Geograpi.Infrastructure.IntegrationTests.Fakers.Extensions;
using Bogus;

namespace Ace.Geograpi.Infrastructure.IntegrationTests.Fakers;

internal sealed class FakeModel : AbstractDataFaker<FakeModel>
{
    private Faker<ContinentModel> FakeContinentModel =>
        new Faker<ContinentModel>(locale: LocaleCode)
            .ConfigureModelId()
            .ConfigureTraceableModel()
            .RuleFor(
                continent => continent.Name,
                f => f.Random.String2(length: 10))
            .RuleFor(
                continent => continent.Countries,
                _ => FakeCountryModel.GenerateBetween(1, 3))
            .StrictMode(ensureRulesForAllProperties: false);

    private Faker<CountryModel> FakeCountryModel =>
        new Faker<CountryModel>(locale: LocaleCode)
            .ConfigureModelId()
            .ConfigureTraceableModel()
            .RuleFor(
                country => country.ContinentId,
                f => f.Random.Int(min: 1))
            .RuleFor(
                country => country.Name,
                f => f.Random.String2(length: 10))
            .StrictMode(ensureRulesForAllProperties: false);
}
