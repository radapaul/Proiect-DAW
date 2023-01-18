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
      return _table.FirstOrDefault(x => x.Stars > number);
    }
    public async Task<Store> GetByStarsAsync(int number)
    {
      return await _table.FirstOrDefaultAsync(x => x.Stars > number);
    }

    public async Task<List<Store>> GetAllWithInclude()
    {
      return await _table.Include(x => x.EmployeesStores).ToListAsync();
    }

    public Store WhereWithLinqQuerySyntax(int star)
    {
      var result = from Store in _table
                   where Store.Stars == star
                   select Store;

      return result.FirstOrDefault();
    }
  }
}
