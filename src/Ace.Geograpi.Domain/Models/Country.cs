using Ace.Geograpi.Domain.Abstractions.Models;

namespace Ace.Geograpi.Domain.Models;

public sealed class Country : TraceableModel<int>
{
    public string Name { get; set; } = default!;
}
