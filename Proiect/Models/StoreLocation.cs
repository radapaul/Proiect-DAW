using Proiect.Models.Base;

namespace Proiect.Models
{
  public class StoreLocation : BaseEntity
  {
    public string City { get; set; } = "";
    public string Street { get; set; } = "";
    public int Number { get; set; }
    public Store Store { get; set; }
   // public Guid StoreId { get; set; }
  }
}
