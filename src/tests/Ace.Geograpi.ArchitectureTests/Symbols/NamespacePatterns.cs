namespace Ace.Geograpi.ArchitectureTests.Symbols;

internal static class NamespacePatterns
{
    public const string System = @"^System(\..+)?$";

    public const string CatNipDomain = @"^CatNip\.Domain(\..+)?$";
    public const string CatNipApplication = @"^CatNip\.Application(\..+)?$";
    public const string CatNipInfrastructure = @"^CatNip\.Infrastructure(\..+)?$";

    public const string DomainEvents = @"^.*\.Domain\.Events(\..+)?$";
    public const string DomainModels = @"^.*\.Domain\.Models(\..+)?$";
    public const string DomainQueryFilters = @"^.*\.Domain\.QueryFilters(\..+)?$";
    public const string DomainRepositories = @"^.*\.Domain\.Repositories(\..+)?$";
    public const string DomainServices = @"^.*\.Domain\.Services(\..+)?$";

    public const string ApplicationServices = @"^.*\.Application\.Services(\..+)?$";
    public const string ApplicationValidators = @"^.*\.Application\.Validators(\..+)?$";
}
