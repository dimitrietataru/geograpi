using Ace.Geograpi.Domain.Models;
using Ace.Geograpi.Domain.QueryFilters;
using CatNip.Domain.Repositories;

namespace Ace.Geograpi.Domain.Repositories;

public interface ICountryRepository : IAceRepository<CountryModel, int, CountryQueryFilter>
{
}
