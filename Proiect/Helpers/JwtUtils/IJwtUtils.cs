using Proiect.Models;

namespace Proiect.Helpers.JwtUtils
{
  public interface IJwtUtils
  {
    public string GenerateJwtToken(Owner admin);
    public Guid ValidateJwtToken(string token);
  }
}
