using Microsoft.AspNetCore.Identity;
using PuchClock.Domain.Constants;
using PuchClock.Domain.Entities;
using PunchClock.Application.Dto;
using PunchClock.Database.Domain;
using System.ComponentModel.DataAnnotations;

namespace PunchClock.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppUserRole> _roleManager;
        private readonly IPunchClockDbContext _dbContext;

        public EmployeeService(UserManager<AppUser> userManager, RoleManager<AppUserRole> roleManager, IPunchClockDbContext punchClockDbContext)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _dbContext = punchClockDbContext;

        }
        public async Task CreateEmployee(EmployeeDto employeeDto)
        {
            try
            {
                var newEmployeeDtls = new AppUser
                {
                    UserName = employeeDto.UserName,
                    FirstName = employeeDto.FirstName,
                    LastName = employeeDto.LastName,
                    Email = employeeDto.Email,


                };
                var employeeDtls = await _userManager.FindByNameAsync(employeeDto.UserName);
                if (employeeDtls != null)
                {
                    throw new ValidationException("Employee already exists");
                }

                var result = await _userManager.CreateAsync(newEmployeeDtls, employeeDto.Password);
                if (!await _roleManager.RoleExistsAsync(Roles.Employee))
                {
                    await _roleManager.CreateAsync(new AppUserRole(Roles.Employee));
                }
                await _userManager.AddToRoleAsync(newEmployeeDtls, Roles.Employee);
                string newId = string.Empty;
                if (result.Succeeded)
                {
                    newId = newEmployeeDtls.Id;
                }
                _dbContext.ClientUserMapping.Add(new ClientUserMapping
                {
                    ClientId = employeeDto.ClientId,
                    UserId = newId
                });
               await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {


            }
        }
    }
}
