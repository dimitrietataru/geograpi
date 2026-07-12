using CatNip.Domain.Events;

namespace Ace.Geograpi.Domain.Events.Continents;

public sealed class ContinentUpdatedEvent : IEvent
{
    public int ContinentId { get; set; }
}
