using Proiect.Models.Base;
using System.Text.Json.Serialization;

namespace Proiect.Models
{
  public class User : BaseEntity
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Username { get; set; }

    [JsonIgnore]
    public string PasswordHash { get; set; }
  }
}
