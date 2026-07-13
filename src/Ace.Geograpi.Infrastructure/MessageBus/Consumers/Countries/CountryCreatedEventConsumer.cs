using Ace.Geograpi.Domain.Events.Countries;

namespace Ace.Geograpi.Infrastructure.MessageBus.Consumers.Countries;

internal sealed class CountryCreatedEventConsumer : IConsumer<CountryCreatedEvent>
{
    private readonly ILogger<CountryCreatedEventConsumer> logger;

    public CountryCreatedEventConsumer(ILogger<CountryCreatedEventConsumer> logger)
    {
        this.logger = logger;
    }

    public Task Consume(ConsumeContext<CountryCreatedEvent> context)
    {
        logger.LogInformation("Received {EventName} event", nameof(CountryCreatedEvent));

        return Task.CompletedTask;
    }
}
