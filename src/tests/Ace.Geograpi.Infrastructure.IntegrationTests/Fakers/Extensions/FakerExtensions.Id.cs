using Bogus;
using CatNip.Domain.Models.Interfaces;
using CatNip.Infrastructure.Data.Entities.Interfaces;

namespace Ace.Geograpi.Infrastructure.IntegrationTests.Fakers.Extensions;

public static partial class FakerExtensions
{
    public static Faker<T> ConfigureEntityId<T>(this Faker<T> faker, int min = 1, int max = 999)
        where T : class, IEntity<int>
    {
        faker.RuleFor(e => e.Id, f => f.Random.Int(min, max));

        return faker;
    }

    public static Faker<T> ConfigureModelId<T>(this Faker<T> faker, int min = 1, int max = 999)
        where T : class, IModel<int>
    {
        faker.RuleFor(m => m.Id, f => f.Random.Int(min, max));

        return faker;
    }
}
