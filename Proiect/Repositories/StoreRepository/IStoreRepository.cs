using Proiect.Models;
using Proiect.Repositories.GenericRepository;

namespace Proiect.Repositories.StoreRepository
{
  public interface IStoreRepository : IGenericRepository<Store>
  {
    public Store FindByName(string name);

    public Task<List<Store>> StoresByStar(int star);

    public List<Store> StoresByStarGroupBy(int star);

  }
}
