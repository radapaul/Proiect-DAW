using Proiect.Data;
using Proiect.Models;
using Proiect.Repositories.GenericRepository;

namespace Proiect.Repositories.OwnerRepository
{
  public class OwnerRepository : GenericRepository<Owner>, IOwnerRepository
  {
    public OwnerRepository(Context context) : base(context)
    {

    }

    public Owner FindByEmail(string email)
    {
      return _table.FirstOrDefault(x => x.Email == email);
    }
  }
}
