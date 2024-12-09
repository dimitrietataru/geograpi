using Ace.Geograpi.Domain.Events.Countries;

namespace Ace.Geograpi.Infrastructure.MessageBus.Consumers.Countries;

internal sealed class CountryDeletedEventConsumer : IConsumer<CountryDeletedEvent>
{
    public Task Consume(ConsumeContext<CountryDeletedEvent> context)
    {
        throw new NotImplementedException();
    }
}
