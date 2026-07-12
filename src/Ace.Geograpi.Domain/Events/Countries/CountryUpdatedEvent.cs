using CatNip.Domain.Events;

namespace Ace.Geograpi.Domain.Events.Countries;

public sealed class CountryUpdatedEvent : IEvent
{
    public int ContinentId { get; set; }
}
