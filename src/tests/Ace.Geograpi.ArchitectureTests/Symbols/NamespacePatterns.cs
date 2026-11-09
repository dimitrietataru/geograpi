namespace Ace.Geograpi.ArchitectureTests.Symbols;

internal static class NamespacePatterns
{
    public const string System = @"^System(\..+)?$";

    public const string CatNipDomain = @"^CatNip\.Domain(\..+)?$";
    public const string CatNipApplication = @"^CatNip\.Application(\..+)?$";
    public const string CatNipInfrastructure = @"^CatNip\.Infrastructure(\..+)?$";

    public const string DomainEvents = @"^Ace\.Geograpi\.Domain\.Events(\..+)?$";
    public const string DomainExchangeDtos = @"^Ace\.Geograpi\.Domain\.ImportExport\.Dtos(\..+)?$";
    public const string DomainModels = @"^Ace\.Geograpi\.Domain\.Models(\..+)?$";
    public const string DomainQueryFilters = @"^Ace\.Geograpi\.Domain\.QueryFilters(\..+)?$";
    public const string DomainRepositories = @"^Ace\.Geograpi\.Domain\.Repositories(\..+)?$";
    public const string DomainServices = @"^Ace\.Geograpi\.Domain\.Services(\..+)?$";

    public const string ApplicationServices = @"^Ace\.Geograpi\.Application\.Services(\..+)?$";
    public const string ApplicationValidators = @"^Ace\.Geograpi\.Application\.Validators(\..+)?$";

    public const string InfrastructureDataConfigurations = @"^Ace\.Geograpi\.Infrastructure\.Data\.Configurations(\..+)?$";
    public const string InfrastructureDataEntities = @"^Ace\.Geograpi\.Infrastructure\.Data\.Entities(\..+)?$";
    public const string InfrastructureCsvMaps = @"^Ace\.Geograpi\.Infrastructure\.ImportExport\.Mappings(\..+)?$";
    public const string InfrastructureExcelMaps = @"^Ace\.Geograpi\.Infrastructure\.ImportExport\.Mappings(\..+)?$";
    public const string InfrastructureConsumers = @"^Ace\.Geograpi\.Infrastructure\.MessageBus\.Consumers(\..+)?$";
    public const string InfrastructureConsumerDefinitions = @"^Ace\.Geograpi\.Infrastructure\.MessageBus\.Consumers(\..+)?$";
    public const string InfrastructureMappers = @"^Ace\.Geograpi\.Infrastructure\.Mappers(\..+)?$";
    public const string InfrastructureRepositories = @"^Ace\.Geograpi\.Infrastructure\.Repositories(\..+)?$";

    public const string WebControllers = @"^Ace\.Geograpi\.Web\.Controllers(\..+)?$";
}
