using Proiect.Data;
using Proiect.Models;
using Proiect.Repositories.GenericRepository;

namespace Proiect.Repositories.StoreRepository
{
  public class StoreRepository : GenericRepository<Store>, IStoreRepository
  {
    public StoreRepository(Context context) : base(context) { }
  }
}
