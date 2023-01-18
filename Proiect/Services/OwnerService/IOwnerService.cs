using Proiect.Models;
using Proiect.Models.DTOs.OwnerAuthRequestDto;
using Proiect.Models.DTOs.OwnerAuthResponseDto;

namespace Proiect.Services.OwnerService
{
  public interface IOwnerService
  {
    OwnerAuthResponseDto Authentificate(OwnerAuthRequestDto model);
    Task Create(OwnerAuthRequestDto newOwner);
    Owner GetById(Guid id);
  }
}
