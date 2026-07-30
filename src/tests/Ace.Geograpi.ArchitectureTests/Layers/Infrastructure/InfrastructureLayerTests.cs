using Ace.Geograpi.ArchitectureTests.Abstractions;
using ArchUnitNET.Domain;

namespace Ace.Geograpi.ArchitectureTests.Layers.Infrastructure;

public sealed class InfrastructureLayerTests : ArchUnitNetBase
{
    private readonly IReadOnlyCollection<string?> allowedExceptions = [
        typeof(Geograpi.Infrastructure.IInfrastructureMarker).FullName,
        typeof(Geograpi.Infrastructure.DependencyInjection).FullName,
        typeof(Geograpi.Infrastructure.Data.GeograpiDbContext).FullName,
        typeof(Geograpi.Infrastructure.Data.Configurations.Seed.ContinentData).FullName,
        typeof(Geograpi.Infrastructure.Data.Configurations.Seed.CountryData).FullName,
        typeof(Geograpi.Infrastructure.Data.Configurations.Symbols.TableNames).FullName,
        typeof(Geograpi.Infrastructure.Data.Configurations.Symbols.TableSchemas).FullName,
        typeof(Geograpi.Infrastructure.Data.Migrations.Interfaces.IGeograpiMigrationProvider).FullName,
        typeof(Geograpi.Infrastructure.Data.Migrations.GeograpiMigrationProvider).FullName,
        typeof(Geograpi.Infrastructure.ImportExport.CsvConverter).FullName,
        typeof(Geograpi.Infrastructure.ImportExport.ExcelConverter).FullName,
        typeof(Geograpi.Infrastructure.MessageBus.EventDefinitions).FullName
    ];

    [Fact]
    internal void InfrastructureTypesShouldBeCoveredByArchitectureRules()
    {
        // Arrange
        var typesWithNoRules = infrastructureTypes.GetObjects(architecture)
            .Except(infrastructureDataConfigurations.GetObjects(architecture))
            .Except(infrastructureDataEntities.GetObjects(architecture))
            .Except(infrastructureCsvMaps.GetObjects(architecture))
            .Except(infrastructureExcelMaps.GetObjects(architecture))
            .Except(infrastructureMappers.GetObjects(architecture))
            .Except(infrastructureConsumers.GetObjects(architecture))
            .Except(infrastructureConsumerDefinitions.GetObjects(architecture))
            .Except(infrastructureMigrations.GetObjects(architecture))
            .Except(infrastructureRepositories.GetObjects(architecture))
            .Where(type => !allowedExceptions.Contains(type.FullName))
            .OfType<IType>()
            .ToList();

        // Assert
        typesWithNoRules.Should().BeEmpty(because: $"Infrastructure types should be covered by architecture rules: {string.Join(", ", typesWithNoRules.Select(t => t.FullName))}");
    }
}
