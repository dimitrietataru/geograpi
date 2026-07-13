using Ace.Geograpi.Domain.Events.Continents;

namespace Ace.Geograpi.Infrastructure.MessageBus.Consumers.Continents;

internal sealed class ContinentUpdatedEventConsumer : IConsumer<ContinentUpdatedEvent>
{
    private readonly ILogger<ContinentUpdatedEventConsumer> logger;

    public ContinentUpdatedEventConsumer(ILogger<ContinentUpdatedEventConsumer> logger)
    {
        this.logger = logger;
    }

    public Task Consume(ConsumeContext<ContinentUpdatedEvent> context)
    {
        logger.LogInformation("Received {EventName} event", nameof(ContinentUpdatedEvent));

        return Task.CompletedTask;
    }
}
