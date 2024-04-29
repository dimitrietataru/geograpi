using Ace.Geograpi.Domain.Symbols.Data;
using Ace.Geograpi.Infrastructure.Data.Entities;

namespace Ace.Geograpi.Infrastructure.Data.Configurations.Seed;

public static class CountryData
{
    public static IEnumerable<CountryEntity> Seed => new List<CountryEntity>
    {
        new()
        {
            Id = CountryId.Afghanistan,
            ContinentId = ContinentId.Africa,
            Name = CountryName.Afghanistan,
        },
        new()
        {
            Id = CountryId.Albania,
            ContinentId = ContinentId.Europe,
            Name = CountryName.Albania,
        },
        new()
        {
            Id = CountryId.Algeria,
            ContinentId = ContinentId.Africa,
            Name = CountryName.Algeria,
        },
        new()
        {
            Id = CountryId.Andorra,
            ContinentId = ContinentId.Europe,
            Name = CountryName.Andorra,
        },
        new()
        {
            Id = CountryId.Angola,
            ContinentId = ContinentId.Africa,
            Name = CountryName.Angola,
        },
        new()
        {
            Id = CountryId.AntiguaAndBarbuda,
            ContinentId = ContinentId.NorthAmerica,
            Name = CountryName.AntiguaAndBarbuda,
        },
        new()
        {
            Id = CountryId.Argentina,
            ContinentId = ContinentId.SouthAmerica,
            Name = CountryName.Argentina,
        },
        new()
        {
            Id = CountryId.Armenia,
            ContinentId = ContinentId.Asia,
            Name = CountryName.Armenia,
        },
        new()
        {
            Id = CountryId.Australia,
            ContinentId = ContinentId.Australia,
            Name = CountryName.Australia,
        },
        new()
        {
            Id = CountryId.Austria,
            ContinentId = ContinentId.Europe,
            Name = CountryName.Austria,
        },
        new()
        {
            Id = CountryId.Azerbaijan,
            ContinentId = ContinentId.Asia,
            Name = CountryName.Azerbaijan,
        }
    };
}
