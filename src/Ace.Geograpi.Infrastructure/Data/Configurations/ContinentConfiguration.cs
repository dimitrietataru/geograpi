using Ace.Geograpi.Infrastructure.Data.Entities;
using Ace.Geograpi.Infrastructure.Symbols;
using CatNip.Infrastructure.Data.Configurations;

namespace Ace.Geograpi.Infrastructure.Data.Configurations;

internal sealed class ContinentConfiguration : TraceableEntityConfiguration<ContinentEntity, int>
{
    public static ContinentConfiguration Instance => new();

    protected override string TableName => TableNames.Continent;

    protected override void ConfigureColumns(EntityTypeBuilder<ContinentEntity> builder)
    {
        base.ConfigureColumns(builder);

        builder
            .Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(100);
    }

    protected override IEnumerable<ContinentEntity> Seed
        => new List<ContinentEntity>
        {
            new()
            {
                Id = 1,
                Name = "Africa"
            },
            new()
            {
                Id = 2,
                Name = "Antarctica"
            },
            new()
            {
                Id = 3,
                Name = "Asia"
            },
            new()
            {
                Id = 4,
                Name = "Australia (Oceania)"
            },
            new()
            {
                Id = 5,
                Name = "Europe"
            },
            new()
            {
                Id = 6,
                Name = "North America"
            },
            new()
            {
                Id = 7,
                Name = "South America"
            }
        };
}
