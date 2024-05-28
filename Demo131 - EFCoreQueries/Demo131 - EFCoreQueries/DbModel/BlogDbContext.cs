using System.Data.Common;
using System.Security.Cryptography;
using Demo131___EFCoreQueries.DbModel.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Demo131___EFCoreQueries.DbModel;

public class BlogDbContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<BlogPost> BlogPosts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Blog>().HasData(new List<Blog>()
        {
            new() { Id = 1, Title = "Hossein Ahmadi Blog", Url = "hahmadi" },
            new() { Id = 2, Title = "Mohammad Nasiri Blog", Url = "mnasiri" },
            new() { Id = 3, Title = "Mehdi Adeli Blog", Url = "madeli"}
        });

        modelBuilder.Entity<BlogPost>().HasQueryFilter(p => !p.Deleted);

        var startDate = new DateTime(2018, 10, 01);
        var dayInc = 1;
        var posts = Enumerable.Range(1, 2000).Select(n => new BlogPost()
        {
            Id = n,
            BlogId = RandomNumberGenerator.GetInt32(1, 4),
            Title = $"Blog post {n}",
            Text = $"This is a text for blog post {n}",
            CreateDate = startDate.AddDays(dayInc++)
        });
        modelBuilder.Entity<BlogPost>().HasData(posts);
        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog=BlogDb; Integrated Security=true; TrustServerCertificate=true; MultipleActiveResultSets=true;");
        optionsBuilder.AddInterceptors(new CommandInterceptor());
        base.OnConfiguring(optionsBuilder);
    }
}

public class CommandInterceptor : Microsoft.EntityFrameworkCore.Diagnostics.DbCommandInterceptor
{
    public override DbDataReader ReaderExecuted(DbCommand command, CommandExecutedEventData eventData, DbDataReader result)
    {
        Console.WriteLine(command.CommandText);
        return base.ReaderExecuted(command, eventData, result);
    }
}