using Ace.Geograpi.Domain.Models;
using Ace.Geograpi.Domain.QueryFilters;
using CatNip.Domain.Services;

namespace Ace.Geograpi.Domain.Services;

public interface IContinentService : IAceService<ContinentModel, int, ContinentQueryFilter>
{
}
