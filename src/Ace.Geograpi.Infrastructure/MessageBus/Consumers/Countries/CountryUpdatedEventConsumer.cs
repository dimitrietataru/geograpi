using Ace.Geograpi.Domain.Events.Countries;

namespace Ace.Geograpi.Infrastructure.MessageBus.Consumers.Countries;

internal sealed class CountryUpdatedEventConsumer : IConsumer<CountryUpdatedEvent>
{
    public Task Consume(ConsumeContext<CountryUpdatedEvent> context)
    {
        throw new NotImplementedException();
    }
}
