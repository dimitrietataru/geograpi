using Ace.Geograpi.Domain.Events.Continents;

namespace Ace.Geograpi.Infrastructure.MessageBus.Consumers.Continents;

internal sealed class ContinentDeletedEventConsumer : IConsumer<ContinentDeletedEvent>
{
    private readonly ILogger<ContinentDeletedEventConsumer> logger;

    public ContinentDeletedEventConsumer(ILogger<ContinentDeletedEventConsumer> logger)
    {
        this.logger = logger;
    }

    public Task Consume(ConsumeContext<ContinentDeletedEvent> context)
    {
        logger.LogInformation("Received {EventName} event", nameof(ContinentDeletedEvent));

        return Task.CompletedTask;
    }
}
