using Proiect.Models;
using Proiect.Repositories.GenericRepository;

namespace Proiect.Repositories.DatabaseRepository
{
  public interface IDatabaseRepository : IGenericRepository<Store>
  {
    Store GetByStars(int number);

    Task<List<Store>> GetAllWithInclude();
  }
}
