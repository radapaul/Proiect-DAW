using AutoMapper;
using Proiect.Models.DTOs;
using Microsoft.EntityFrameworkCore.Migrations;
using Proiect.Services;
using Proiect.Repositories.StoreRepository;
using Proiect.Repositories.EmployeeRepository;
using Proiect.Models;

namespace Demo.Services.CourseService
{
  public class StoreService : IStoreService
  {
    public IStoreRepository _storeRepository;

    public IEmployeeRepository _employeeRepository;
    public IMapper _mapper;
    public StoreService(IStoreRepository storeRepository, IMapper mapper, IEmployeeRepository employeeRepository)
    {
      _storeRepository = storeRepository;
      _employeeRepository = employeeRepository;
      _mapper = mapper;
    }

    public async Task AddStore(StoreDto newStore)
    {
      var newDbStore = _mapper.Map<Store>(newStore);
      await _storeRepository.CreateAsync(newDbStore);
      await _storeRepository.SaveAsync();
    }

    public async Task DeleteStore(Guid storeId)
    {
      var store = await _storeRepository.FindByIdAsync(storeId);
      _storeRepository.Delete(store);
      await _storeRepository.SaveAsync();
    }

    public async Task<List<StoreDto>> GetAllStores()
    {
      var stores = await _storeRepository.GetAllAsync();
      return _mapper.Map<List<StoreDto>>(stores);
    }
  }
}
