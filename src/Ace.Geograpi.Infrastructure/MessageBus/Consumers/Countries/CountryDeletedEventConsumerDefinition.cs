namespace Ace.Geograpi.Infrastructure.MessageBus.Consumers.Countries;

internal sealed class CountryDeletedEventConsumerDefinition
    : ConsumerDefinition<CountryDeletedEventConsumer>
{
    public CountryDeletedEventConsumerDefinition()
    {
        EndpointName = "geograpi-country-deleted";
    }
}
