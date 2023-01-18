using Proiect.Models;
using Proiect.Repositories.GenericRepository;

namespace Proiect.Repositories.OwnerRepository
{
  public interface IOwnerRepository : IGenericRepository<Owner>
  {
    Owner FindByEmail(string email);
  }
}
