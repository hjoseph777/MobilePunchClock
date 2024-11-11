using PunchClock.Api.Extensions;
using PunchClock.Application.Services;
using PunchClock.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApplicationServices(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// create super admin account
using (var scope = app.Services.CreateScope())
{
    var accountService = scope.ServiceProvider.GetRequiredService<IAccountSevice>();
    try
    {
        await accountService.CreateSuperAdminAccount();
    }
    catch (System.Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

if (builder.Configuration.GetValue<bool>("RunMigration"))
{
    using (var scope = app.Services.CreateScope())
    {
        var dbContext = scope.ServiceProvider
            .GetRequiredService<PunchClockDbContext>();

        // Here is the migration executed
        dbContext.Database.Migrate();
    }
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
