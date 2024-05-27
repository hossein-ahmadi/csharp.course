using System.Collections.ObjectModel;
using Demo128___EFCore.Base;
using Demo128___EFCore.DbModel;
using Demo128___EFCore.ViewModels.Books.QueryModels;

namespace Demo128___EFCore.ViewModels.Books;

public class BooksListViewModel : ViewModelBase
{
    private readonly ApplicationDbContext dbContext;
    public ObservableCollection<QueryModels.BookModel> Books { get; set; }

    public BooksListViewModel(ApplicationDbContext dbContext)
    {
        this.dbContext = dbContext;
        ReloadItems();
    }

    public void ReloadItems()
    {
        Books = new ObservableCollection<BookModel>(dbContext.Books
            .Select(b => new QueryModels.BookModel()
            {
                Id = b.Id,
                CategoryTitle = b.Category.Title,
                Title = b.Title,
                ISBN = b.ISBN,
                Author = b.Authors.FirstOrDefault().Name
            }).ToList());
    }
}