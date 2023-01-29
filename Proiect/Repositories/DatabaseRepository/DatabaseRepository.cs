using Proiect.Data;
using Proiect.Models;
using Proiect.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace Proiect.Repositories.DatabaseRepository
{
  public class DatabaseRepository : GenericRepository<Store>, IDatabaseRepository
  {
    public DatabaseRepository(Context Context) : base(Context)
    {

    }

    public Store GetByStars(int number)
    {
      return _table.FirstOrDefault(x => x.Stars >= number);
    }
    public async Task<Store> GetByStarsAsync(int number)
    {
      return await _table.FirstOrDefaultAsync(x => x.Stars >= number);
    }

    //include
    public async Task<List<Store>> GetAllWithInclude()
    {
      return await _table.Include(x => x.EmployeesStores).ToListAsync();
    }


    //join
    public async Task<List<Store>> GetAllWithJoin()
    {
      var result = _table.Join(_context.Owners, store => store.Id, owner => owner.Id,
          (store, owner) => new { store, owner }).Select(x => x.store);
      return await result.ToListAsync();
    }



  }
}
