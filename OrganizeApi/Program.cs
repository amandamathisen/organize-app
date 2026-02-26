using Microsoft.EntityFrameworkCore;
using OrganizeApi.Data;


var builder = WebApplication.CreateBuilder(args);

// Registrera DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=organize.db"));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
/* builder.Services.AddOpenApi(); */

var app = builder.Build();

// Configure the HTTP request pipeline.
/* if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization(); */

app.MapControllers();

app.Run();
