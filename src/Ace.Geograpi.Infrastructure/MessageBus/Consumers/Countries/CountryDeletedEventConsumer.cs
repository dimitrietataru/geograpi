using Ace.Geograpi.Domain.Events.Countries;

namespace Ace.Geograpi.Infrastructure.MessageBus.Consumers.Countries;

internal sealed class CountryDeletedEventConsumer : IConsumer<CountryDeletedEvent>
{
    private readonly ILogger<CountryDeletedEventConsumer> logger;

    public CountryDeletedEventConsumer(ILogger<CountryDeletedEventConsumer> logger)
    {
        this.logger = logger;
    }

    public Task Consume(ConsumeContext<CountryDeletedEvent> context)
    {
        logger.LogInformation("Received {EventName} event", nameof(CountryDeletedEvent));

        return Task.CompletedTask;
    }
}
