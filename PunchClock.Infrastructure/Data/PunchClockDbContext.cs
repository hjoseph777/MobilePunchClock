using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PuchClock.Domain.Entities;
using PunchClock.Application.Services;
using PunchClock.Database.Domain;
using System.Reflection;

namespace PunchClock.Infrastructure.Data
{
    public class PunchClockDbContext : IdentityDbContext<AppUser, AppUserRole, string>, IPunchClockDbContext
    {

        public PunchClockDbContext(DbContextOptions<PunchClockDbContext> options) : base(options)
        {

        }

        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<ClientUserMapping> ClientUserMapping { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly(),
                t => t.GetInterfaces().Any(i => i.IsGenericType
                && i.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>)));

            base.OnModelCreating(builder);
        }
    }
}
