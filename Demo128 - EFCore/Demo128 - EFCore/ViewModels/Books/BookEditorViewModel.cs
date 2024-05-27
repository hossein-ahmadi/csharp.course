using System.Windows;
using System.Windows.Input;
using Demo128___EFCore.Base;
using Demo128___EFCore.DbModel;
using Demo128___EFCore.DbModel.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo128___EFCore.ViewModels.Books;

public class BookEditorViewModel : ViewModelBase
{
    private readonly ApplicationDbContext dbContext;
    private BookCategory? category;
    private string? title;
    private string? isbn;
    private Author? author;
    private int? id;

    public event EventHandler OnSubmitSuccess;

    public List<BookCategory> Categories { get; set; }
    public List<Author> Authors { get; set; }

    public BookEditorViewModel(ApplicationDbContext dbContext)
    {
        this.dbContext = dbContext;
        Categories = dbContext.BookCategories.AsNoTracking().OrderBy(c => c.Title).ToList();
        Authors = dbContext.Authors.AsNoTracking().OrderBy(c => c.Name).ToList();
    }

    public int? Id
    {
        get => id;
        set => SetProperty(ref id, value);
    }

    public BookCategory? Category
    {
        get => category;
        set => SetProperty(ref category, value);
    }

    public string? Title
    {
        get => title;
        set => SetProperty(ref title, value);
    }

    public string? ISBN
    {
        get => isbn;
        set => SetProperty(ref isbn, value);
    }

    public Author? Author
    {
        get => author;
        set => SetProperty(ref author, value);
    }

    public ICommand SubmitChangesCommand => ResolveCommand("Books.Editor.SubmitChanges", SubmitChanges);

    private void SubmitChanges()
    {
        Book book;
        if (Id.HasValue)
        {
            book = dbContext.Books.Include(b=>b.Authors).First(b => b.Id == Id);
        }
        else
        {
            book = new Book()
            {
                Authors = new List<Author>()
            };
            dbContext.Books.Add(book);
        }
        book.Authors.Clear();
        book.Title = Title;
        book.ISBN = ISBN;
        book.CategoryId = Category.Id;
        book.Authors.Add(Author);
        dbContext.SaveChanges();
        Id = book.Id;
        OnSubmitSuccess?.Invoke(this, EventArgs.Empty);
    }
}