using Proiect.Models;
using Proiect.Repositories.GenericRepository;

namespace Proiect.Repositories.EmployeeRepository
{
  public interface IEmployeeRepository : IGenericRepository<Employee>
  {
        Employee FindById(Guid employeeId);
    }
}
