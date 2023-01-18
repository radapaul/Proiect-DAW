using Proiect.Data;
using Proiect.Models;

namespace Proiect.Helpers.Seeders
{
  public class EmployeesSeeder
  {
    public readonly Context _Context;

    public EmployeesSeeder(Context Context)
    {
      _Context = Context;
    }

    public void SeedInitialStudents()
    {
      if (!_Context.Employees.Any())
      {
        var employee1 = new Employee
        {
          FirstName = "Paul",
          LastName = "Rada",
          Age = 20
        };
        var employee2 = new Employee
        {
          FirstName = "Matei",
          LastName = "Haberstoch",
          Age = 22
        };

        _Context.Employees.Add(employee1);
        _Context.Employees.Add(employee2);

        _Context.SaveChanges();
      }
    }
  }
}
