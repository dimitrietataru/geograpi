using Ace.Geograpi.Domain.ImportExport.Dtos;
using Ace.Geograpi.Domain.Models;
using Ace.Geograpi.Domain.Models.Root;
using Ace.Geograpi.Domain.QueryFilters;
using CatNip.Domain.Repositories;

namespace Ace.Geograpi.Domain.Repositories;

public interface ICountryRepository : IAceRepository<CountryModel, int, CountryRootModel, CountryQueryFilter, CountryExchangeDto>
{
}
