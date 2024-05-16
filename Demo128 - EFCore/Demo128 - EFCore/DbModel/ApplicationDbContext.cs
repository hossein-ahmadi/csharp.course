using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Demo128___EFCore.DbModel;

public class ApplicationDbContext(IConfiguration configuration) : DbContext
{
    public DbSet<Entities.User> Users { get; set; }
    public DbSet<Entities.Member> Members { get; set; }
    public DbSet<Entities.Author> Authors { get; set; }
    public DbSet<Entities.BookCategory> BookCategories { get; set; }
    public DbSet<Entities.Book> Books { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(EntityConfigurations.UserConfiguration).Assembly);
        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = configuration.GetConnectionString("LibraryDb");
        optionsBuilder.UseSqlServer(connectionString);
        base.OnConfiguring(optionsBuilder);
    }
}