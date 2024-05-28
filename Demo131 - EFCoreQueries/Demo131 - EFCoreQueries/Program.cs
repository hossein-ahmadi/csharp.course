// Demo131 - EF Core Queries
// TOSINSO C# Mega Course

using Demo131___EFCoreQueries.DbModel;
using Microsoft.EntityFrameworkCore;

var dbContext = new BlogDbContext();

// Batch update and delete
dbContext.BlogPosts.Where(p => p.Id > 200 && p.Id < 300)
    .ExecuteUpdate(sp => sp.SetProperty(post => post.Deleted, true));

dbContext.Blogs
    .Select(b=>new{Entity = b, TotalPosts = b.Posts.Count})
    .ExecuteUpdate(sp => sp.SetProperty(b => b.Entity.PostsCount, b => b.TotalPosts));

dbContext.BlogPosts.Where(p => p.Id > 900 && p.Id < 950).ExecuteDelete();

var blogs = dbContext.Blogs
    .Select(b=>new
    {
        b.Id,
        b.Title,
        Url = ToolsFunctions.StandardUrl(b.Url),
        PostsCount = b.Posts.Count,
        PostsWithEvenId = b.Posts
            .Select(p=>new
            {
                p.Id,
                p.Title
            }).Where(p=>p.Id % 2 == 0).ToList()
    }).ToList();

foreach (var blog in blogs)
{
    Console.WriteLine($"{blog.Title} has url {blog.Url} with {blog.PostsCount}");
}

var allPosts = dbContext.BlogPosts/*.IgnoreQueryFilters()*/.ToList();

Console.WriteLine($"Deleted posts: {allPosts.Count(p => p.Deleted)}");

var allBlogPosts = dbContext.BlogPosts.FromSql($"SELECT * FROM BlogPosts")
    .Where(b=>b.Id > 100)
    .ToList();

var allIds = dbContext.Database.SqlQuery<int>($"SELECT Id [Value] FROM BlogPosts")
    .Where(id=>id > 1000)
    .ToList();

Console.ReadKey();

public class ToolsFunctions
{
    public static string StandardUrl(string input)
    {
        return $"https://tosinso.com/blogs/{input}";
    }
}