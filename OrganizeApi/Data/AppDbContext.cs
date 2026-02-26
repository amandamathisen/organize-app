using Microsoft.EntityFrameworkCore;
using OrganizeApi.Models; // Importera Models

namespace OrganizeApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<ToDo> Todos => Set<ToDo>();
}