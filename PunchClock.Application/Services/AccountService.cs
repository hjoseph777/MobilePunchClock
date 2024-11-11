using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using PuchClock.Domain.Constants;
using PuchClock.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PunchClock.Application.Services
{
    public class AccountService : IAccountSevice
    {
        private readonly UserManager<AppUser> _userManager;
        public readonly SuperAdminConfig _superAdminConfig;
        private readonly RoleManager<AppUserRole> _roleManager;
        private readonly ITokenService _tokenService;
        public AccountService(UserManager<AppUser> userManager, RoleManager<AppUserRole> roleManager, IOptions<SuperAdminConfig> superAdminConfig, ITokenService tokenService)
        {
            _userManager = userManager;
            _superAdminConfig = superAdminConfig.Value;
            _roleManager = roleManager;
            _tokenService = tokenService;
        }
        public async Task CreateSuperAdminAccount()
        {
            try
            {

                List<Claim> claims = new()
        {
            new Claim(ClaimTypes.NameIdentifier, ""),
            new Claim(ClaimTypes.Name, "sajan"),
        };
                
                var accessToken = _tokenService.GenerateAccessToken(claims);

                var appuser = new AppUser
                {
                    UserName = _superAdminConfig.UserId,
                    FirstName = _superAdminConfig.Name,
                    LastName = ""
                };
                var superAdminAccount = await _userManager.FindByNameAsync(appuser.UserName);
                if (superAdminAccount != null)
                {
                    throw new ValidationException("Super Admin account already exists");
                }

                var result = await _userManager.CreateAsync(appuser, _superAdminConfig.Password);
                if (!await _roleManager.RoleExistsAsync(Roles.SuperAdmin))
                {
                    await _roleManager.CreateAsync(new AppUserRole(Roles.SuperAdmin));
                }
                var accountresult = await _userManager.AddToRoleAsync(appuser, Roles.SuperAdmin);
                if (accountresult != null)
                {

                }
            }
            catch (Exception ex)
            {

            }

        }
    }
}
