using Ace.Geograpi.Domain.Symbols;
using Ace.Geograpi.Infrastructure.Data.Configurations.Seed;
using Ace.Geograpi.Infrastructure.Data.Configurations.Symbols;
using Ace.Geograpi.Infrastructure.Data.Entities;
using CatNip.Infrastructure.Data.Configurations;

namespace Ace.Geograpi.Infrastructure.Data.Configurations;

internal sealed class CountryConfiguration : TraceableEntityConfiguration<CountryEntity, int>
{
    public static CountryConfiguration Instance => new();

    protected sealed override string TableName => TableNames.Country;
    protected sealed override string? TableSchema => TableSchemas.Default;
    protected sealed override IEnumerable<CountryEntity> Seed => CountryData.Seed;

    protected sealed override void ConfigureKeys(EntityTypeBuilder<CountryEntity> builder)
    {
        base.ConfigureKeys(builder);

        builder
            .Property(e => e.ContinentId)
            .IsRequired();
    }

    protected sealed override void ConfigureRelationships(EntityTypeBuilder<CountryEntity> builder)
    {
        base.ConfigureRelationships(builder);

        builder
            .HasOne(c => c.Continent)
            .WithMany(c => c.Countries)
            .HasForeignKey(c => c.ContinentId);
    }

    protected sealed override void ConfigureColumns(EntityTypeBuilder<CountryEntity> builder)
    {
        base.ConfigureColumns(builder);

        builder
            .Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(Constraints.CountryNameMaxLength);
    }
}
