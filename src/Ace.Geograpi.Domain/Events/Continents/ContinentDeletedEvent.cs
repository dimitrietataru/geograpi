using CatNip.Domain.Events;

namespace Ace.Geograpi.Domain.Events.Continents;

public sealed class ContinentDeletedEvent : IEvent
{
    public int ContinentId { get; set; }
}
