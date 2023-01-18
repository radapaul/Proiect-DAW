using Demo.Helpers.Attributes;
using Microsoft.AspNetCore.Mvc;
using Proiect.Models.DTOs;
using Proiect.Models.Enums;
using Proiect.Services;

namespace Proiect.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class StoreController : ControllerBase
  {
    public readonly IStoreService _storeService;

    public StoreController(IStoreService storeService)
    {
      _storeService = storeService;
    }

    [HttpGet]
    [Authorization(Role.Admin)]
    public async Task<IActionResult> GetAll()
    {
      return Ok(await _storeService.GetAllStores());
    }

    [HttpPost]
    [Authorization(Role.Admin)]
    public async Task<IActionResult> AddStore(StoreDto newStore)
    {
      await this._storeService.AddStore(newStore);
      return Ok();
    }

    [HttpDelete("{storeId}")]
    [Authorization(Role.Admin)]
    public async Task<IActionResult> DeleteStore([FromRoute] Guid storeId)
    {
      await this._storeService.DeleteStore(storeId);
      return Ok(await _storeService.GetAllStores());
    }
  }
}
