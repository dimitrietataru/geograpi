using Ace.Geograpi.Domain.Events.Continents;

namespace Ace.Geograpi.Infrastructure.MessageBus.Consumers.Continents;

internal sealed class ContinentCreatedEventConsumer : IConsumer<ContinentCreatedEvent>
{
    public Task Consume(ConsumeContext<ContinentCreatedEvent> context)
    {
        throw new NotImplementedException();
    }
}
