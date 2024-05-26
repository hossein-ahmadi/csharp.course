using System.Collections.ObjectModel;
using Demo128___EFCore.Base;
using Demo128___EFCore.DbModel;
using Demo128___EFCore.DbModel.Entities;

namespace Demo128___EFCore.ViewModels.BookCategories;

public class BookCategoriesListViewModel : ViewModelBase
{
    public BookCategoriesListViewModel(ApplicationDbContext dbContext)
    {
        this.Categories = new ObservableCollection<BookCategory>(dbContext.BookCategories.OrderBy(c => c.Title).ToList());
    }

    public ObservableCollection<BookCategory> Categories { get; set; }
}