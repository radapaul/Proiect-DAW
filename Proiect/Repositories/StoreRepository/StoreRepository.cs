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

    //where
    public async Task<List<Store>> StoresByStar(int star)
    {
      return await _table.Where(x => x.Stars>=star).ToListAsync();
    }

    //groupby
    public List<Store> StoresByStarGroupBy(int star)
    {
      return _table.GroupBy(x => x.Stars).First(gr => gr.Key == star).ToList();

    }
  }
}
