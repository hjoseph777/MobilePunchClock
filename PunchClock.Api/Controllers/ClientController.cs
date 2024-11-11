using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PunchClock.Application.Dto;
using PunchClock.Application.Services;

namespace PunchClock.Api.Controllers
{
    [ApiController]
    [Authorize]
    [Route("client")]
    public class ClientController : Controller
    {

        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpPost, AllowAnonymous]
        public async Task<ActionResult> CreateClient(ClientDto clientDto)
        {
            await _clientService.CreateClient(clientDto);
            return Ok();
        }
    }
}
