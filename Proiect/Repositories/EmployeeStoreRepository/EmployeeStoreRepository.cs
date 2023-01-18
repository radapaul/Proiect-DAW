using Proiect.Data;
using Proiect.Models;
using Proiect.Repositories.GenericRepository;

namespace Proiect.Repositories.EmployeeStoreRepository
{
  public class EmployeeStoreRepository : GenericRepository<EmployeeStore>, IEmployeeStoreRepository
  {
    public EmployeeStoreRepository(Context context) : base(context) { }
  }
}
