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
            .Property(c => c.ContinentId)
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
            .Property(c => c.Code)
            .IsRequired()
            .HasMaxLength(Constraints.CountryCodeMaxLength)
            .HasDefaultValue(string.Empty);

        builder
            .Property(c => c.CodeA3)
            .IsRequired()
            .HasMaxLength(Constraints.CountryCodeA3MaxLength)
            .HasDefaultValue(string.Empty);

        builder
            .Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(Constraints.CountryNameMaxLength);

        builder
            .Property(c => c.NameOfficial)
            .IsRequired()
            .HasMaxLength(Constraints.CountryNameOfficialMaxLength)
            .HasDefaultValue(string.Empty);

        builder
            .Property(c => c.Area)
            .IsRequired()
            .HasPrecision(10, 2)
            .HasDefaultValue(0);

        builder
            .Property(c => c.Population)
            .IsRequired()
            .HasDefaultValue(0);
    }
}
