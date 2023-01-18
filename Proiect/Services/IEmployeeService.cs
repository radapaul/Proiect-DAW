using Proiect.Models.DTOs;

namespace Proiect.Services
{
  public interface IEmployeeService
  {
    public Task DeleteEmployee(Guid employeeId);
    Task<List<EmployeeDto>> GetAllEmployees();

  }
}
