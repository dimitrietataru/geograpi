using Ace.Geograpi.Domain.Abstractions.Services;
using Ace.Geograpi.Domain.Models;
using Ace.Geograpi.Domain.RequestQueries;

namespace Ace.Geograpi.Domain.Services;

public interface IContinentService : ICrudService<Continent, int, ContinentRequestQuery>
{
}
