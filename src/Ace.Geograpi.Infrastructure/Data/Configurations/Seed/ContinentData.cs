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
            Name = ContinentName.Africa,
        },
        new()
        {
            Id = ContinentId.Antarctica,
            Name = ContinentName.Antarctica
        },
        new()
        {
            Id = ContinentId.Asia,
            Name = ContinentName.Asia
        },
        new()
        {
            Id = ContinentId.Australia,
            Name = ContinentName.Australia
        },
        new()
        {
            Id = ContinentId.Europe,
            Name = ContinentName.Europe
        },
        new()
        {
            Id = ContinentId.NorthAmerica,
            Name = ContinentName.NorthAmerica
        },
        new()
        {
            Id = ContinentId.SouthAmerica,
            Name = ContinentName.SouthAmerica
        },
    };
}
