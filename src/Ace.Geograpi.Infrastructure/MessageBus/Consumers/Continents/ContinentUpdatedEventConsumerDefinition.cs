namespace Ace.Geograpi.Infrastructure.MessageBus.Consumers.Continents;

internal sealed class ContinentUpdatedEventConsumerDefinition
    : ConsumerDefinition<ContinentUpdatedEventConsumer>
{
    public ContinentUpdatedEventConsumerDefinition()
    {
        EndpointName = "geograpi-continent-updated";
    }
}
