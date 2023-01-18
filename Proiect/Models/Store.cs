using Proiect.Models.Base;

namespace Proiect.Models
{
  public class Store : BaseEntity
  {
    public string Name { get; set; } = "";
    public int Stars { get; set; }
    public string? Type { get; set; }

    public ICollection<EmployeeStore> EmployeesStores { get; set; }

    public Owner Owner { get; set; }

    public StoreLocation Location { get; set; }
  }

}
