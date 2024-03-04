using Bogus;
using CatNip.Domain.Models.Interfaces;
using CatNip.Infrastructure.Data.Entities.Interfaces;

namespace Ace.Geograpi.Infrastructure.IntegrationTests.Fakers.Extensions;

public static partial class FakerExtensions
{
    public static Faker<T> ConfigureTraceableEntity<T>(this Faker<T> faker)
        where T : class, ITraceableEntity<int, int>
    {
        faker.RuleFor(e => e.CreatedAt, f => f.Date.PastOffset(yearsToGoBack: 1));
        faker.RuleFor(e => e.CreatedBy, f => f.Random.Int(min: 1, max: 999));

        faker.RuleFor(e => e.UpdatedAt, f => f.Date.RecentOffset(days: 7));
        faker.RuleFor(e => e.UpdatedBy, f => f.Random.Int(min: 1, max: 999));

        faker.RuleFor(e => e.IsDeleted, _ => false);
        faker.RuleFor(e => e.DeletedAt, _ => default);
        faker.RuleFor(e => e.DeletedBy, _ => default);

        return faker;
    }

    public static Faker<T> ConfigureTraceableModel<T>(this Faker<T> faker)
        where T : class, ITraceableModel<int, int>
    {
        faker.RuleFor(m => m.CreatedAt, f => f.Date.PastOffset(yearsToGoBack: 1));
        faker.RuleFor(m => m.CreatedBy, f => f.Random.Int(min: 1, max: 999));

        faker.RuleFor(m => m.UpdatedAt, f => f.Date.RecentOffset(days: 7));
        faker.RuleFor(m => m.UpdatedBy, f => f.Random.Int(min: 1, max: 999));

        faker.RuleFor(m => m.IsDeleted, _ => false);
        faker.RuleFor(m => m.DeletedAt, _ => default);
        faker.RuleFor(m => m.DeletedBy, _ => default);

        return faker;
    }
}
