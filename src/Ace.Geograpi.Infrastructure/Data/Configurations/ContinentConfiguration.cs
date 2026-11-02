using Ace.Geograpi.Domain.Symbols;
using Ace.Geograpi.Infrastructure.Data.Configurations.Seed;
using Ace.Geograpi.Infrastructure.Data.Configurations.Symbols;
using Ace.Geograpi.Infrastructure.Data.Entities;
using CatNip.Infrastructure.Data.Configurations;

namespace Ace.Geograpi.Infrastructure.Data.Configurations;

internal sealed class ContinentConfiguration : TraceableEntityConfiguration<ContinentEntity, int>
{
    public static ContinentConfiguration Instance => new();

    protected sealed override string TableName => TableNames.Continent;
    protected sealed override string? TableSchema => TableSchemas.Default;
    protected sealed override IEnumerable<ContinentEntity> Seed => ContinentData.Seed;

    protected sealed override void ConfigureColumns(EntityTypeBuilder<ContinentEntity> builder)
    {
        base.ConfigureColumns(builder);

        builder
            .Property(c => c.Code)
            .IsRequired()
            .HasMaxLength(Constraints.ContinentCodeMaxLength);

        builder
            .Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(Constraints.ContinentNameMaxLength);

        builder
            .Property(c => c.GoogleId)
            .IsRequired()
            .HasMaxLength(Constraints.ContinentGoogleIdMaxLength)
            .HasDefaultValue(string.Empty);

        builder
            .Property(c => c.BoundaryN)
            .IsRequired()
            .HasPrecision(11, 8)
            .HasDefaultValue(0);

        builder
            .Property(c => c.BoundaryS)
            .IsRequired()
            .HasPrecision(11, 8)
            .HasDefaultValue(0);

        builder
            .Property(c => c.BoundaryE)
            .IsRequired()
            .HasPrecision(11, 8)
            .HasDefaultValue(0);

        builder
            .Property(c => c.BoundaryW)
            .IsRequired()
            .HasPrecision(11, 8)
            .HasDefaultValue(0);

        builder
            .Property(c => c.CenterLat)
            .IsRequired()
            .HasPrecision(11, 8)
            .HasDefaultValue(0);

        builder
            .Property(c => c.CenterLng)
            .IsRequired()
            .HasPrecision(11, 8)
            .HasDefaultValue(0);
    }
}
