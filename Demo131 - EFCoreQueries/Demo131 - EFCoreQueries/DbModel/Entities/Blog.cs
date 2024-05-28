using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Demo131___EFCoreQueries.DbModel.Entities;

public class Blog
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Url { get; set; }
    public int PostsCount { get; set; }

    public virtual List<BlogPost> Posts { get; set; } = new();
}

public class BlogPost
{
    private readonly ILazyLoader lazyLoader;
    private Blog blog;

    public BlogPost()
    {
        
    }

    public BlogPost(ILazyLoader lazyLoader)
    {
        this.lazyLoader = lazyLoader;
    }

    public int Id { get; set; }

    public virtual Blog Blog
    {
        get => lazyLoader.Load(this, ref blog);
        set => blog = value;
    }

    public int BlogId { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
    public DateTime CreateDate { get; set; }
    public bool Deleted { get; set; }
}