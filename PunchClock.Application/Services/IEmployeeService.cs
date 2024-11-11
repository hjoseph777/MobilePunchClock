using PunchClock.Application.Dto;

namespace PunchClock.Application.Services
{
    public interface IEmployeeService
    {
        Task CreateEmployee(EmployeeDto employeeDto);
    }
}
