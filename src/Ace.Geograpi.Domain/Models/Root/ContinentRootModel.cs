using CatNip.Domain.Models;

namespace Ace.Geograpi.Domain.Models.Root;

public sealed class ContinentRootModel : Model<int>
{
    public string Code { get; set; } = default!;
    public string Name { get; set; } = default!;
}
