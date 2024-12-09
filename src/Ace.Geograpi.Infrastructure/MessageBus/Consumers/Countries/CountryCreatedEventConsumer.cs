using Ace.Geograpi.Domain.Events.Countries;

namespace Ace.Geograpi.Infrastructure.MessageBus.Consumers.Countries;

internal sealed class CountryCreatedEventConsumer : IConsumer<CountryCreatedEvent>
{
    public Task Consume(ConsumeContext<CountryCreatedEvent> context)
    {
        throw new NotImplementedException();
    }
}
