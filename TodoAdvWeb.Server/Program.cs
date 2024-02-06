using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TodoAdvWeb.Server.Areas.Identity.Data;
using TodoAdvWeb.Server.Data;
using TodoAdvWeb.Server.Models;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("TodoContextConnection") ?? throw new InvalidOperationException("Connection string 'TodoContextConnection' not found.");

builder.Services.AddDbContext<TodoContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<TodoUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<TodoContext>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    try
    {
        SeedData.EnsurePopulated(services).Wait();
    } catch (Exception ex)
    {
        // print an error message to the console
        var logger = services.GetRequiredService<ILogger<Program>>();

        logger.LogError(ex, "An error occured seeding the database.");
    }

}


app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapRazorPages();

app.MapFallbackToFile("/index.html");

app.Run();
