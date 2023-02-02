using Proiect.Data;
using Proiect.Models;
using Proiect.Repositories.GenericRepository;

namespace Proiect.Repositories.EmployeeRepository
{
  public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
  {
    public EmployeeRepository(Context context) : base(context) { }
    public Employee FindById(Guid employeeId)
    {
        var employee = _table.FirstOrDefault(x => x.Id == employeeId);
        return employee;
    }
    }
}
