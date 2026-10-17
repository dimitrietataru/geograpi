using Ace.Geograpi.Domain.Symbols.Data;
using Ace.Geograpi.Infrastructure.Data.Entities;

namespace Ace.Geograpi.Infrastructure.Data.Configurations.Seed;

public static class ContinentData
{
    public static IEnumerable<ContinentEntity> Seed => new List<ContinentEntity>
    {
        new()
        {
            Id = ContinentId.Africa,
            Code = ContinentCode.Africa,
            Name = ContinentName.Africa,
        },
        new()
        {
            Id = ContinentId.Antarctica,
            Code = ContinentCode.Antarctica,
            Name = ContinentName.Antarctica
        },
        new()
        {
            Id = ContinentId.Asia,
            Code = ContinentCode.Asia,
            Name = ContinentName.Asia
        },
        new()
        {
            Id = ContinentId.Europe,
            Code = ContinentCode.Europe,
            Name = ContinentName.Europe
        },
        new()
        {
            Id = ContinentId.Oceania,
            Code = ContinentCode.Oceania,
            Name = ContinentName.Oceania
        },
        new()
        {
            Id = ContinentId.NorthAmerica,
            Code = ContinentCode.NorthAmerica,
            Name = ContinentName.NorthAmerica
        },
        new()
        {
            Id = ContinentId.SouthAmerica,
            Code = ContinentCode.SouthAmerica,
            Name = ContinentName.SouthAmerica
        },
    };
}
