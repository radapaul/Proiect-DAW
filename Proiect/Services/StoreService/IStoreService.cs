using Proiect.Models.DTOs;

namespace Proiect.Services
{
  public interface IStoreService
  {
    public Task DeleteStore(Guid StoreId);
    public Task<List<StoreDto>> GetAllStores();

    public Task AddStore(StoreDto newStore);
  }
}
