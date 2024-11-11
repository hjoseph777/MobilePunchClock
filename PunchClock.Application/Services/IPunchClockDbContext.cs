using Microsoft.EntityFrameworkCore;
using PuchClock.Domain.Entities;
using PunchClock.Database.Domain;

namespace PunchClock.Application.Services
{
    public interface IPunchClockDbContext
    {
        DbSet<AppUser> AppUsers { get; set; }
        DbSet<Client> Clients { get; set; }
        DbSet<ClientUserMapping> ClientUserMapping { get; set; }
        DbSet<Employee> Employees { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}