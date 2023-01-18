using Proiect.Models.Base;
using Proiect.Models.Enums;
using System.Text.Json.Serialization;

namespace Proiect.Models
{
  public class Owner : BaseEntity
  {
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public int Age { get; set; }
    public string? Email { get; set; }

    public ICollection<Store>? Stores { get; set; }

    public Role Role { get; set; }

    [JsonIgnore]
    public string PasswordHash { get; set; } = string.Empty;
  }
}
