namespace Ace.Geograpi.Infrastructure.MessageBus.Consumers.Countries;

internal sealed class CountryUpdatedEventConsumerDefinition
    : ConsumerDefinition<CountryUpdatedEventConsumer>
{
    public CountryUpdatedEventConsumerDefinition()
    {
        EndpointName = "geograpi-country-updated";
    }
}
