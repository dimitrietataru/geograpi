namespace Ace.Geograpi.Infrastructure.MessageBus.Consumers.Continents;

internal sealed class ContinentCreatedEventConsumerDefinition
    : ConsumerDefinition<ContinentCreatedEventConsumer>
{
    public ContinentCreatedEventConsumerDefinition()
    {
        EndpointName = "geograpi-continent-created";
    }
}
