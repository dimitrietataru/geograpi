using Ace.Geograpi.Infrastructure.Abstractions.Data;

namespace Ace.Geograpi.Infrastructure.Data.Entities;

internal sealed class Country : TraceableEntity<int>
{
    public string Name { get; set; } = default!;
}
