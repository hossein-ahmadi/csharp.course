using Microsoft.EntityFrameworkCore;

namespace Demo128___EFCore.DbModel;

public class ApplicationDbContext : DbContext
{
    public DbSet<Entities.User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog=LibraryDb; Integrated Security=true; MultipleActiveResultSets=true; TrustServerCertificate=true;");
        base.OnConfiguring(optionsBuilder);
    }
}