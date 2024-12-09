namespace Ace.Geograpi.Infrastructure.MessageBus.Consumers.Continents;

internal sealed class ContinentDeletedEventConsumerDefinition
    : ConsumerDefinition<ContinentDeletedEventConsumer>
{
    public ContinentDeletedEventConsumerDefinition()
    {
        EndpointName = "geograpi-continent-deleted";
    }
}
