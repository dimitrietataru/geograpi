using Ace.Geograpi.Infrastructure.Data.Entities;
using Ace.Geograpi.Infrastructure.Symbols;
using CatNip.Infrastructure.Data.Configurations;

namespace Ace.Geograpi.Infrastructure.Data.Configurations;

internal sealed class CountryConfiguration : TraceableEntityConfiguration<CountryEntity, int>
{
    public static CountryConfiguration Instance => new();

    protected override string TableName => TableNames.Country;

    protected override void ConfigureKeys(EntityTypeBuilder<CountryEntity> builder)
    {
        base.ConfigureKeys(builder);

        builder
            .Property(e => e.ContinentId)
            .IsRequired();
    }

    protected override void ConfigureRelationships(EntityTypeBuilder<CountryEntity> builder)
    {
        base.ConfigureRelationships(builder);

        builder
            .HasOne(c => c.Continent)
            .WithMany(c => c.Countries)
            .HasForeignKey(c => c.ContinentId);
    }

    protected override void ConfigureColumns(EntityTypeBuilder<CountryEntity> builder)
    {
        base.ConfigureColumns(builder);

        builder
            .Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(100);
    }
}
