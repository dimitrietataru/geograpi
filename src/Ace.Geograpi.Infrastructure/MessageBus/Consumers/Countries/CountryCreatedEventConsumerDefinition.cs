namespace Ace.Geograpi.Infrastructure.MessageBus.Consumers.Countries;

internal sealed class CountryCreatedEventConsumerDefinition
    : ConsumerDefinition<CountryCreatedEventConsumer>
{
    public CountryCreatedEventConsumerDefinition()
    {
        EndpointName = "geograpi-country-created";
    }
}
