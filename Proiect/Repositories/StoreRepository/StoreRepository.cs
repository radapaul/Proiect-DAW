using Proiect.Data;
using Proiect.Models;
using Proiect.Repositories.GenericRepository;
using System.Data.Entity;

namespace Proiect.Repositories.StoreRepository
{
  public class StoreRepository : GenericRepository<Store>, IStoreRepository
  {
    public StoreRepository(Context context) : base(context) { }

    public Store FindByName(string name)
    {
      return _table.FirstOrDefault(x => x.Name == name);
    }
  }
}
