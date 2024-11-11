using Microsoft.AspNetCore.Identity;
using PuchClock.Domain.Entities;
using PunchClock.Application.Dto;
using PunchClock.Database.Domain;

namespace PunchClock.Application.Services
{
    public class ClientService : IClientService
    {
        private readonly IPunchClockDbContext _punchClockDbContext;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppUserRole> _roleManager;

        public ClientService(IPunchClockDbContext punchClockDbContext, UserManager<AppUser> userManager, RoleManager<AppUserRole> roleManager)
        {
            _punchClockDbContext = punchClockDbContext;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task CreateClient(ClientDto clientDto)
        {
            var client = new Client
            {

                WebAddress = clientDto.WebAddress,
                Email = clientDto.Email,
                Phone = clientDto.Phone,
                Country = clientDto.Country,
                Address = clientDto.Address,
                City = clientDto.City,
                PostalCode = clientDto.PostalCode,
                State = clientDto.State,

            };

            _punchClockDbContext.Clients.Add(client);
            await _punchClockDbContext.SaveChangesAsync();


        }

       
    }
}
