// Demo130 - EF Core Lazy Loading
// TOSINSO C# Mega Course

using Demo130___EFCoreLazyLoading.DbModel;
using Microsoft.EntityFrameworkCore;

var context = new BlogDbContext();

var blog = context.Blogs.Find(1);
var post = context.BlogPosts.Find(500);

// Explicit loading

var blogEntry = context.Entry(blog);
var postEntry = context.Entry(post);


blogEntry.Collection(b => b.Posts).Load();
postEntry.Reference(p=>p.Blog).Load();

// Eager Loading

var posts = context.BlogPosts
    .Where(p => p.Id > 100 && p.Id < 200)
    .Include(p => p.Blog)
    .ToList();

// Lazy load interface

var post200 = context.BlogPosts.Find(400);

Console.WriteLine(post200.Blog.Title);

Console.ReadKey();