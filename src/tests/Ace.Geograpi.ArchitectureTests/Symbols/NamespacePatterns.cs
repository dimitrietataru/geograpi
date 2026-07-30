namespace Ace.Geograpi.ArchitectureTests.Symbols;

internal static class NamespacePatterns
{
    public const string System = @"^System(\..+)?$";

    public const string CatNipDomain = @"^CatNip\.Domain(\..+)?$";
    public const string CatNipApplication = @"^CatNip\.Application(\..+)?$";
    public const string CatNipInfrastructure = @"^CatNip\.Infrastructure(\..+)?$";

    public const string DomainEvents = @"^.*\.Domain\.Events(\..+)?$";
    public const string DomainExchangeDtos = @"^.*\.Domain\.ImportExport\.Dtos(\..+)?$";
    public const string DomainModels = @"^.*\.Domain\.Models(\..+)?$";
    public const string DomainQueryFilters = @"^.*\.Domain\.QueryFilters(\..+)?$";
    public const string DomainRepositories = @"^.*\.Domain\.Repositories(\..+)?$";
    public const string DomainServices = @"^.*\.Domain\.Services(\..+)?$";

    public const string ApplicationServices = @"^.*\.Application\.Services(\..+)?$";
    public const string ApplicationValidators = @"^.*\.Application\.Validators(\..+)?$";

    public const string InfrastructureDataConfigurations = @"^.*\.Infrastructure\.Data\.Configurations(\..+)?$";
    public const string InfrastructureDataEntities = @"^.*\.Infrastructure\.Data\.Entities(\..+)?$";
    public const string InfrastructureCsvMaps = @"^.*\.Infrastructure\.ImportExport\.Mappings(\..+)?$";
    public const string InfrastructureExcelMaps = @"^.*\.Infrastructure\.ImportExport\.Mappings(\..+)?$";
    public const string InfrastructureConsumers = @"^.*\.Infrastructure\.MessageBus\.Consumers(\..+)?$";
    public const string InfrastructureConsumerDefinitions = @"^.*\.Infrastructure\.MessageBus\.Consumers(\..+)?$";
    public const string InfrastructureMappers = @"^.*\.Infrastructure\.Mappers(\..+)?$";
    public const string InfrastructureRepositories = @"^.*\.Infrastructure\.Repositories(\..+)?$";

    public const string WebControllers = @"^.*\.Web\.Controllers(\..+)?$";
}
