using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MovieApp.Data;
using MovieApp.Models;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MovieAppContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("MovieAppContext") ?? throw new InvalidOperationException("Connection string 'MovieAppContext' not found.")));

builder.Services.AddControllersWithViews();

var app = builder.Build();

    using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    try
    {
        SeedData.Initialize(services);
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred seeding the DB.");
    }
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

