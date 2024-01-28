using Ace.Geograpi.Domain.Models;
using Ace.Geograpi.Domain.QueryFilters;
using CatNip.Domain.Repositories;

namespace Ace.Geograpi.Domain.Repositories;

public interface IContinentRepository : IAceRepository<Continent, int, ContinentQueryFilter>
{
}
