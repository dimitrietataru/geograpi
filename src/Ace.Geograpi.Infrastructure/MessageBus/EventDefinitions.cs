namespace Ace.Geograpi.Infrastructure.MessageBus;

public static class EventDefinitions
{
    public const string ContinentCreated = "continent-created";
    public const string ContinentUpdated = "continent-updated";
    public const string ContinentDeleted = "continent-deleted";

    public const string CountryCreated = "country-created";
    public const string CountryUpdated = "country-updated";
    public const string CountryDeleted = "country-deleted";
}
