using Demo.Helpers.Attributes;
using Microsoft.AspNetCore.Mvc;
using Proiect.Models;
using Proiect.Models.Enums;
using Proiect.Services;

namespace Proiect.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class EmployeeController : ControllerBase
  {

    public readonly IEmployeeService _employeeService;

    public EmployeeController(IEmployeeService employeeService)
    {
      _employeeService = employeeService;
    }

    [HttpGet]
    public IActionResult GetAllEmployees()
    {
      return Ok(_employeeService.GetAllEmployees());
    }

    [HttpDelete("{employeeId}")]
    [Authorization(Role.Admin)]
    public async Task<IActionResult> DeleteEmployee([FromRoute] Guid employeeId)
    {
      await this._employeeService.DeleteEmployee(employeeId);
      return Ok(await _employeeService.GetAllEmployees());
    }
  }
}
