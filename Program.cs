using ApiStoreWeb.Models.Context;
using ApiStoreWeb.Repository;
using ApiStoreWeb.Repository.PurchaseRepository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ISmartphoneRepository, SmartphoneRepository>();
builder.Services.AddScoped<IPurchaseRepository, PurchaseRepository>();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<SmartphoneContext>(options =>
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)).LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
});

builder.Services.AddControllers();

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<SmartphoneContext>();
    context.Database.EnsureCreated();
}
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors(config =>
{
    config.AllowAnyHeader();
    config.AllowAnyMethod();
    config.AllowAnyOrigin();
});
app.Run();
