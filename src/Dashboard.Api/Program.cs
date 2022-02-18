using Dashboard.Api.Configuration;
using Dashboard.Data.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddApiConfig();
builder.Services.ResolveDependencies();


var app = builder.Build();
app.UseApiConfig(app.Environment);
app.MapControllers();
app.Run();