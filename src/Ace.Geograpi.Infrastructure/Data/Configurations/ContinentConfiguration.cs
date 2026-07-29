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
            .Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(Constraints.ContinentNameMaxLength);
    }
}
