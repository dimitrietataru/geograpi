using Ace.Geograpi.Domain.Events.Continents;

namespace Ace.Geograpi.Infrastructure.MessageBus.Consumers.Continents;

internal sealed class ContinentUpdatedEventConsumer : IConsumer<ContinentUpdatedEvent>
{
    public Task Consume(ConsumeContext<ContinentUpdatedEvent> context)
    {
        throw new NotImplementedException();
    }
}
