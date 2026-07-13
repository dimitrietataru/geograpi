using Ace.Geograpi.Domain.Events.Countries;

namespace Ace.Geograpi.Infrastructure.MessageBus.Consumers.Countries;

internal sealed class CountryUpdatedEventConsumer : IConsumer<CountryUpdatedEvent>
{
    private readonly ILogger<CountryUpdatedEventConsumer> logger;

    public CountryUpdatedEventConsumer(ILogger<CountryUpdatedEventConsumer> logger)
    {
        this.logger = logger;
    }

    public Task Consume(ConsumeContext<CountryUpdatedEvent> context)
    {
        logger.LogInformation("Received {EventName} event", nameof(CountryUpdatedEvent));

        return Task.CompletedTask;
    }
}
