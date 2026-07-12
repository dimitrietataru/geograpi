using CatNip.Domain.Events;

namespace Ace.Geograpi.Domain.Events.Countries;

public sealed class CountryCreatedEvent : IEvent
{
    public int ContinentId { get; set; }
}
