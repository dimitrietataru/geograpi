using CatNip.Domain.Events;

namespace Ace.Geograpi.Domain.Events.Continents;

public sealed class ContinentCreatedEvent : IEvent
{
    public int ContinentId { get; set; }
}
