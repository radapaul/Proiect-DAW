using Proiect.Repositories.EmployeeRepository;
using Proiect.Models.DTOs;
using AutoMapper;
using Proiect.Models;

namespace Proiect.Services
{
    public class EmployeeService : IEmployeeService
    {
        public IEmployeeRepository _employeeRepository;
        public IMapper _mapper;

        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public async Task<List<EmployeeDto>> GetAllEmployees()
        {
            var employees = await _employeeRepository.GetAllAsync();
            List<EmployeeDto> result = _mapper.Map<List<EmployeeDto>>(employees);

            return result;
        }
        public async Task DeleteEmployee(Guid employeeId)
        {
            var employee = await _employeeRepository.FindByIdAsync(employeeId);
            _employeeRepository.Delete(employee);
            await _employeeRepository.SaveAsync();
        }
        public Employee FindById(Guid employeeId)
        {
            var employee = _employeeRepository.FindById(employeeId);
            return employee;
        }
    }
}
