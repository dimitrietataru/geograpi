using Ace.Geograpi.Domain.Abstractions.Query.Params;

namespace Ace.Geograpi.Domain.RequestQueries;

public sealed class ContinentRequestQuery : QueryParams<int>
{
    public string? Name { get; set; }
}
