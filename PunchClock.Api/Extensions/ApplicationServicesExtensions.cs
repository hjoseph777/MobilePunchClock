using Microsoft.EntityFrameworkCore;
using PuchClock.Domain.Entities;
using PunchClock.Application.Services;
using PunchClock.Infrastructure.Data;

namespace PunchClock.Api.Extensions
{
    public static class ApplicationServicesExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration _configuration)
        {
        
            services.AddDbContext<IPunchClockDbContext , PunchClockDbContext>(options =>
            {
                string conn = _configuration.GetConnectionString("DbConnection");
                options.UseSqlServer(conn);
            });


            services.AddIdentity<AppUser, AppUserRole>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 5;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
            })
            .AddEntityFrameworkStores< PunchClockDbContext>();

            services.Configure<SuperAdminConfig>(_configuration.GetSection("SuperAdminConfig"));
            services.Configure<JwtSettings>(_configuration.GetSection("JwtSettings"));
            services.AddScoped<IAccountSevice, AccountService>();

            services.AddScoped<IClientService, ClientService>();

            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            

            return services;
        }
    }
}
