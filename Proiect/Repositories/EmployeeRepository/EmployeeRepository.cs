using Proiect.Data;
using Proiect.Models;
using Proiect.Repositories.GenericRepository;

namespace Proiect.Repositories.EmployeeRepository
{
  public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
  {
    public EmployeeRepository(Context context) : base(context) { }
  }
}
