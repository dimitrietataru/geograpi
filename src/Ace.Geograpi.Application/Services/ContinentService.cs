using Ace.Geograpi.Domain.Models;
using Ace.Geograpi.Domain.QueryFilters;
using Ace.Geograpi.Domain.Repositories;
using Ace.Geograpi.Domain.Services;
using CatNip.Application.Services;

namespace Ace.Geograpi.Application.Services;

internal sealed class ContinentService
    : AceService<IContinentRepository, ContinentModel, int, ContinentQueryFilter>, IContinentService
{
    public ContinentService(IContinentRepository repository)
        : base(repository)
    {
    }
}
