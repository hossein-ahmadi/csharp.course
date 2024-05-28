using System.Security.Cryptography;
using Demo130___EFCoreLazyLoading.DbModel.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo130___EFCoreLazyLoading.DbModel;

public class BlogDbContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<BlogPost> BlogPosts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Blog>().HasData(new List<Blog>()
        {
            new() { Id = 1, Title = "Blog1" },
            new() { Id = 2, Title = "Blog2" },
            new() { Id = 3, Title = "Blog3" }
        });

        var posts = Enumerable.Range(1, 1000).Select(n => new BlogPost()
        {
            Id = n,
            BlogId = RandomNumberGenerator.GetInt32(1, 4),
            Title = $"Blog post {n}",
            Text = $"This is a text for blog post {n}",
            CreateDate = DateTime.Now
        });
        modelBuilder.Entity<BlogPost>().HasData(posts);
        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseLazyLoadingProxies(false)
            .UseSqlServer("Data Source=.; Initial Catalog=BlogDb; Integrated Security=true; TrustServerCertificate=true; MultipleActiveResultSets=true;");
        base.OnConfiguring(optionsBuilder);
    }
}