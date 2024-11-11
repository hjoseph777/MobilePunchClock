using PunchClock.Application.Dto;


namespace PunchClock.Application.Services
{
    public interface IClientService
    {
        Task CreateClient(ClientDto clientDto);
    }
}
