using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PunchClock.Application.Dto;
using PunchClock.Application.Services;

namespace PunchClock.Api.Controllers
{
    
        [ApiController]
        [Authorize]
        [Route("employee")]
        public class EmployeeController : Controller
        {
            private readonly IEmployeeService _employeeService;
            public EmployeeController(IEmployeeService employeeService)
            {
                _employeeService = employeeService;
            }

            [HttpPost, AllowAnonymous]
            public async Task<IActionResult> CreateEmployee(EmployeeDto employeeDto)
            {
                await _employeeService.CreateEmployee(employeeDto);
                return Ok();
            }
        }

    
}
