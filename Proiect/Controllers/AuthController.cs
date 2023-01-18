using Microsoft.AspNetCore.Mvc;
using Proiect.Models.DTOs.OwnerAuthRequestDto;
using Proiect.Services.OwnerService;

namespace Proiect.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AuthController : ControllerBase
  {
    private IOwnerService _ownerService;

    public AuthController(IOwnerService ownerService)
    {
      _ownerService = ownerService;
    }

    [HttpPost("create-owner")]
    public async Task<IActionResult> CreateOwner(OwnerAuthRequestDto admin)
    {
      await _ownerService.Create(admin);
      return Ok();
    }

    [HttpPost("login-owner")]
    public IActionResult LoginOwner(OwnerAuthRequestDto admin)
    {
      var response = _ownerService.Authentificate(admin);
      if (response == null)
      {
        return BadRequest("Wrong username or password!");
      }
      return Ok(response);
    }
  }
}
