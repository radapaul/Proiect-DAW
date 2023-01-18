namespace Proiect.Models.DTOs
{
  public class EmployeeDto
  {
    public Guid Id { get; set; }

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public int Age { get; set; }

    public string Email { get; set; } = string.Empty;

    public ICollection<StoreDto>? Stores { get; set; }
  }
}
