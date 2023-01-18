namespace Proiect.Models
{
  public class EmployeeStore
  {
    public Guid EmployeeId { get; set; }
    public Employee Employee { get; set; }


    public Guid StoreId { get; set; }
    public Store Store { get; set; }
  }
}
