using Proiect.Models.Base;

namespace Proiect.Models
{
  public class Employee : BaseEntity
  {
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public int Age { get; set; }
    public string? Email { get; set; }
    public string? Title { get; set; } = "";

    public ICollection<EmployeeStore>? EmployeesStores { get; set; }
  }

}
