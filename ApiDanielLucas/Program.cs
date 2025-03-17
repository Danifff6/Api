using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ApiDanielLucas.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApiDanielLucasContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ApiDanielLucasContext") ?? throw new InvalidOperationException("Connection string 'ApiDanielLucasContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
