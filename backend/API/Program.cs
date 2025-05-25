using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.MapControllers();

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.MapOpenApi();
// }

using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;

try 
{
    var context = services.GetRequiredService<AppDbContext>();
    await context.Database.MigrateAsync();
    // Seed the database with initial data
    await DbInitializer.SeeData(context);
}
catch (Exception ex)
{
    var logger = services.GetRequiredService<ILogger<Program>>();
    logger.LogError(ex, "An error occurred during database initialization");
}



app.Run();
