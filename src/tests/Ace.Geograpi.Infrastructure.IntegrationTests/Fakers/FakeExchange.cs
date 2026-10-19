using Ace.CSharp.DataFaker;
using Ace.Geograpi.Domain.ImportExport.Dtos;
using Ace.Geograpi.Domain.Symbols.Data;
using Bogus;

namespace Ace.Geograpi.Infrastructure.IntegrationTests.Fakers;

public sealed class FakeExchange : AbstractDataFaker<FakeExchange>
{
    private Faker<ContinentExchangeDto> FakeContinentExchangeDto =>
        new Faker<ContinentExchangeDto>(locale: LocaleCode)
            .RuleFor(
                dto => dto.RowNumber,
                f => f.Random.Int(min: 1, max: 100))
            .RuleFor(
                dto => dto.Code,
                f => f.PickRandom(
                    ContinentCode.Africa,
                    ContinentCode.Antarctica,
                    ContinentCode.Asia,
                    ContinentCode.Europe,
                    ContinentCode.Oceania,
                    ContinentCode.NorthAmerica,
                    ContinentCode.SouthAmerica))
            .RuleFor(
                dto => dto.Name,
                f => f.PickRandom(
                    ContinentName.Africa,
                    ContinentName.Antarctica,
                    ContinentName.Asia,
                    ContinentName.Europe,
                    ContinentName.Oceania,
                    ContinentName.NorthAmerica,
                    ContinentName.SouthAmerica))
            .StrictMode(ensureRulesForAllProperties: true);

    private Faker<CountryExchangeDto> FakeCountryExchangeDto =>
        new Faker<CountryExchangeDto>(locale: LocaleCode)
            .RuleFor(
                dto => dto.RowNumber,
                f => f.Random.Int(min: 1, max: 100))
            .RuleFor(
                dto => dto.ContinentCode,
                f => f.PickRandom(
                    ContinentCode.Africa,
                    ContinentCode.Antarctica,
                    ContinentCode.Asia,
                    ContinentCode.Europe,
                    ContinentCode.Oceania,
                    ContinentCode.NorthAmerica,
                    ContinentCode.SouthAmerica))
            .RuleFor(
                country => country.Code,
                f => f.Random.String2(length: 2))
            .RuleFor(
                country => country.CodeA3,
                f => f.Random.String2(length: 3))
            .RuleFor(
                country => country.Name,
                f => f.Random.String2(length: 10))
            .RuleFor(
                country => country.NameOfficial,
                f => f.Random.String2(length: 20))
            .RuleFor(
                country => country.Area,
                f => Math.Round(f.Random.Double(min: 1, max: 1_000_000), 2))
            .RuleFor(
                country => country.Population,
                f => f.Random.Int(min: 10_000, max: 1_000_000_000))
            .StrictMode(ensureRulesForAllProperties: true);
}
