using Ace.Geograpi.Domain.Events.Continents;

namespace Ace.Geograpi.Infrastructure.MessageBus.Consumers.Continents;

internal sealed class ContinentDeletedEventConsumer : IConsumer<ContinentDeletedEvent>
{
    public Task Consume(ConsumeContext<ContinentDeletedEvent> context)
    {
        throw new NotImplementedException();
    }
}
