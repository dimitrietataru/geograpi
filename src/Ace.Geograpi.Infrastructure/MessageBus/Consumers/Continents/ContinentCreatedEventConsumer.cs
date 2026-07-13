using Ace.Geograpi.Domain.Events.Continents;

namespace Ace.Geograpi.Infrastructure.MessageBus.Consumers.Continents;

internal sealed class ContinentCreatedEventConsumer : IConsumer<ContinentCreatedEvent>
{
    private readonly ILogger<ContinentCreatedEventConsumer> logger;

    public ContinentCreatedEventConsumer(ILogger<ContinentCreatedEventConsumer> logger)
    {
        this.logger = logger;
    }

    public Task Consume(ConsumeContext<ContinentCreatedEvent> context)
    {
        logger.LogInformation("Received {EventName} event", nameof(ContinentCreatedEvent));

        return Task.CompletedTask;
    }
}
