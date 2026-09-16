using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace veterinariaCrud.models;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connStr = ConfigurationManager.ConnectionStrings["veterinariaCrud"].ConnectionString;

        optionsBuilder.UseMySql(
            connStr,
            new MySqlServerVersion(new Version(8, 0, 0))
        );
    }

    public DbSet<Mascota> Mascotas { get; set; }
}